using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Xml;
using SIFLess.Model.Profiles;
using SIFLess.Model.Validation;

namespace SIFLess.Validators.Default.Solr
{
   public class VersionValidator :ISolrValidator
    {
        public string ErrorMessage { get; set; }
        public string Text => "Is Valid Solr Version";

        public bool Validate(SolrProfile profile)
        {
            var minVersion = Version.Parse(ConfigurationManager.AppSettings["SolrRequiredVersion"]);
            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync(profile.Url + "/admin/info/system").Result)
                {
                    using (var content = response.Content)
                    {
                        var responseXML = content.ReadAsStringAsync().Result;

                        var responseDoc = new XmlDocument();
                        responseDoc.LoadXml(responseXML);

                        var versionNode =
                            responseDoc.SelectSingleNode("//response/lst[@name='lucene']/str[@name='solr-spec-version']");

                        var versionText = versionNode.InnerText;

                        var runningVersion = Version.Parse(versionText);

                        if (runningVersion < minVersion)
                        {
                            ErrorMessage = $"Invalid Solr Version: [{runningVersion}] (Expected: {minVersion}";
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
