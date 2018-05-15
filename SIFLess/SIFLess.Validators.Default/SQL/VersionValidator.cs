using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using SIFLess.Model.Profiles;
using SIFLess.Model.Validation;

namespace SIFLess.Validators.Default.SQL
{
   public class VersionValidator : ISqlValidator
    {
        public string ErrorMessage { get; set; }

        public string Text => "Is SQL 2016+";

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

                    var command = new SqlCommand("SELECT @@VERSION", connection);
                    var result = command.ExecuteScalar().ToString();

                    if (result.IndexOf("SQL Server 2016") >= 0 || result.IndexOf("SQL Server 2017") >= 0)
                    {
                        return true;
                    }

                    ErrorMessage = $"Invalid Version: {result}";
                    return false;

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
