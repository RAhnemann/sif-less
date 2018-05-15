using System;
using System.Net;
using SIFLess.Model.Profiles;
using SIFLess.Model.Validation;

namespace SIFLess.Validators.Default.Solr
{
    public class ValidUrlValidator : ISolrValidator
    {
        public string ErrorMessage { get; set; }
        public string Text => "Is Valid Solr Url";
        public bool Validate(SolrProfile profile)
        {
            try
            {
                if (!profile.Url.ToLower().StartsWith("https"))
                {
                    ErrorMessage = "URL should start with 'https'";
                    return false;
                }

                if (!profile.Url.ToLower().EndsWith("/solr"))
                {
                    ErrorMessage = "Url should end at /solr";
                    return false;
                }

                var request = WebRequest.Create(profile.Url + "/admin/info/system");

                var response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    ErrorMessage = "Non-Ok Response in Url Check: " + response.StatusDescription;
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = "Error checking URL: " + ex.Message;
                return false;
            }
        }
    }
}