using System;
using System.Data.SqlClient;
using SIFLess.Model.Profiles;
using SIFLess.Model.Validation;

namespace SIFLess.Validators.Default.SQL
{
    public class LoginValidator : ISqlValidator
    {
        public string ErrorMessage { get; set; }

        public string Text => "Connect to Server";

        public bool Validate(SqlProfile profile)
        {
            var sqlBuilder = new SqlConnectionStringBuilder
            {
                DataSource = profile.ServerName,
                UserID = profile.Login,
                Password = profile.Password
            };

            using (var connection = new SqlConnection(sqlBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    ErrorMessage = ex.Message;
                    return false;
                }

            }
        }
    }
}
