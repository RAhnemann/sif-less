using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SIFLess.Model.Managers;
using SIFLess.Model.Profiles;
using SIFLess.Model.Validation;

namespace SIFLess
{
    public partial class ConnectionCreateProfile : Form
    {
        private  SqlProfile _profile;
        private readonly IProfileManager _profileManager;
        private readonly List<ISqlValidator> _validators;
        private readonly List<Label> _validatorLabels;


        public void SetProfile(SqlProfile profile)
        {
            _profile = profile;

            profileTextBox.Text = profile.Name;
            connectionNameTextBox.Text = profile.ServerName;
            loginTextBox.Text = profile.Login;
            passwordTextBox.Text = profile.Password;

            validateButton.Text = "Update Profile";
        }
        public ConnectionCreateProfile(IProfileManager profileManager)
        {
            _profileManager = profileManager;
            InitializeComponent();

            var configSection = (ValidationConfigurationSection)ConfigurationManager.GetSection("sifless.validation");

            var typesNames = configSection.Validators.SQL.Cast<ValidatorType>().ToList();

            _validators = new List<ISqlValidator>();
            _validatorLabels = new List<Label>();

            typesNames.ForEach(typeName =>
            {
                Type type = Type.GetType(typeName.Type);
                var handle = Activator.CreateInstance(type);

                var validator = (ISqlValidator) handle;
                var label = new Label() {Text = validator.Text, Width=300};

                validationPanel.Controls.Add(label);

                _validators.Add(validator);
                _validatorLabels.Add(label);
            });

            validationPanel.Controls.SetChildIndex(validateButton, 100);
        }

        private void validateButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(profileTextBox.Text))
            {
                MessageBox.Show("Need a Profile Name!");
                return;
            }

            if (string.IsNullOrWhiteSpace(connectionNameTextBox.Text))
            {
                MessageBox.Show("Enter a Server");
                return;
            }

            if (string.IsNullOrWhiteSpace(loginTextBox.Text))
            {
                MessageBox.Show("Enter a Login");
                return;
            }

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Enter a Password");
                return;
            }

            var sqlProfile = new SqlProfile
            {
                Name = profileTextBox.Text,
                ServerName = connectionNameTextBox.Text,
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text
            };

            for(var i = 0; i< _validators.Count; i++)
            {
                var validator = _validators[i];

                var isValid = validator.Validate(sqlProfile);

                if (isValid)
                {
                    _validatorLabels[i].ForeColor = Color.Green;
                }
                else
                {
                    _validatorLabels[i].ForeColor = Color.Red;

                    MessageBox.Show(validator.ErrorMessage, "Validation Failed", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    //Stop.
                    return;
                }
            }

            var sifProfiles = _profileManager.Fetch();

            if (_profile == null)
            {
                sqlProfile.Id = Guid.NewGuid();

                sifProfiles.SqlProfiles.Add(sqlProfile);
            }
            else
            {
                var profile = sifProfiles.SqlProfiles.Find(p => p.Id == _profile.Id);

                profile.Name = profileTextBox.Text;
                profile.ServerName = connectionNameTextBox.Text;
                profile.Login = loginTextBox.Text;
                profile.Password = passwordTextBox.Text;
            }

            _profileManager.Update(sifProfiles);

            this.Close();

        }
    }
}
