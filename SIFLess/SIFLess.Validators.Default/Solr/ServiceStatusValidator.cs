using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using SIFLess.Model.Profiles;
using SIFLess.Model.Validation;

namespace SIFLess.Validators.Default.Solr
{
    public class ServiceStatusValidator : ISolrValidator
    {
        public string ErrorMessage { get; set; }
        public string Text => "Solr Service is running";
        public bool Validate(SolrProfile profile)
        {
            using (var sc = new ServiceController(profile.ServiceName))
            {
                if (sc.Status != ServiceControllerStatus.Running)
                {

                    ErrorMessage = $"Service Not in Running State: State={sc.Status.ToString()}";
                    return false;
                }
            }

            return true;
        }
    }
}
