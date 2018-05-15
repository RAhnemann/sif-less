using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Windows.Forms;
using SIFLess.Model.Managers;
using SIFLess.Model.Profiles;
using SIFLess.Model.Validation;

namespace SIFLess
{
    public partial class SolrCreateProfile : Form
    {
        private SolrProfile _profile;
        private readonly IProfileManager _profileManager;
        private readonly List<ISolrValidator> _validators;
        private readonly List<Label> _validatorLabels;

        public SolrCreateProfile(IProfileManager profileManager)
        {
            _profileManager = profileManager;
            InitializeComponent();
            InitServices();


            var configSection = (ValidationConfigurationSection)ConfigurationManager.GetSection("sifless.validation");

            var typesNames = configSection.Validators.Solr.Cast<ValidatorType>().ToList();

            _validators = new List<ISolrValidator>();
            _validatorLabels = new List<Label>();

            typesNames.ForEach(typeName =>
            {
                Type type = Type.GetType(typeName.Type);
                var handle = Activator.CreateInstance(type);

                var validator = (ISolrValidator)handle;
                var label = new Label() { Text = validator.Text, Width = 300 };

                validationPanel.Controls.Add(label);

                _validators.Add(validator);
                _validatorLabels.Add(label);
            });

            validationPanel.Controls.SetChildIndex(validateButton, 100);
        }

        public void SetProfile(SolrProfile profile)
        {
            _profile = profile;
            profileTextBox.Text = profile.Name;
            urlTextBox.Text = profile.Url;
            serviceComboBox.SelectedItem = profile.ServiceName;
            corePathTextBox.Text = profile.CorePath;

            validateButton.Text = "Update Profile";
        }

        private void validateButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(profileTextBox.Text))
            {
                MessageBox.Show("Enter a Profile Name!");
                return;
            }

            if (string.IsNullOrWhiteSpace(urlTextBox.Text))
            {
                MessageBox.Show("Enter a Url");
                return;
            }

            if (serviceComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select a Service");
                return;
            }

            if (string.IsNullOrWhiteSpace(corePathTextBox.Text))
            {
                MessageBox.Show("Enter a Core Path");
                return;
            }

            var solrProfile = new SolrProfile
            {
                Name = profileTextBox.Text,
                Url = urlTextBox.Text,
                ServiceName = serviceComboBox.SelectedItem.ToString(),
                CorePath = corePathTextBox.Text
            };

            for (var i = 0; i < _validators.Count; i++)
            {
                var validator = _validators[i];

                var isValid = validator.Validate(solrProfile);

                if (isValid)
                {
                    _validatorLabels[i].ForeColor = Color.Green;
                }
                else
                {
                    _validatorLabels[i].ForeColor = Color.Red;

                    MessageBox.Show(validator.ErrorMessage, "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    //Stop.
                    return;
                }
            }


            var currentProfiles = _profileManager.Fetch();

            if (_profile == null)
            {
                solrProfile.Id = Guid.NewGuid();

                currentProfiles.SolrProfiles.Add(solrProfile);
            }
            else
            {
                var profile = currentProfiles.SolrProfiles.Find(p => p.Id == _profile.Id);

                profile.Name = profileTextBox.Text;
                profile.Url = urlTextBox.Text;
                profile.ServiceName = serviceComboBox.SelectedItem.ToString();
                profile.CorePath = corePathTextBox.Text;
            }


            _profileManager.Update(currentProfiles);

            this.Close();

        }

        private void InitServices()
        {
            serviceComboBox.Items.Clear();

            var services = ServiceController.GetServices();

            foreach (var serviceController in services)
            {
                serviceComboBox.Items.Add(serviceController.ServiceName);
            }
        }

        private void setCorePathBox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = solrCorePathBrowser.ShowDialog();

            if (result == DialogResult.OK)
            {
                corePathTextBox.Text = solrCorePathBrowser.SelectedPath;
            }
        }
    }
}
