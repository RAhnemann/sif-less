using System;
using System.Data.SqlClient;
using SIFLess.Model.Profiles;
using SIFLess.Model.Validation;

namespace SIFLess.Validators.Default.SQL
{
    public class DatabaseCreateValidator : ISqlValidator
    {
        public string ErrorMessage { get; set; }

        public string Text => "Can Create a Database";

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

                    var command = new SqlCommand("SELECT has_perms_by_name(null, null, 'CREATE ANY DATABASE')", connection);
                    var result = command.ExecuteScalar().ToString();

                    if (result != "1")
                    {
                        ErrorMessage = "Unable to create databases";
                        return false;
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    ErrorMessage = "Error testing database creation: " + ex.Message;
                    return false;
                }
            }
        }
    }
}