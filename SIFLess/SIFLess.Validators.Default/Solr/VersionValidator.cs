using Newtonsoft.Json.Linq;
using SIFLess.Model.Profiles;
using SIFLess.Model.Validation;
using System;
using System.Configuration;
using System.Net.Http;
using System.Xml;

namespace SIFLess.Validators.Default.Solr
{
    public class VersionValidator : ISolrValidator
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
                        var responseText = content.ReadAsStringAsync().Result.Trim();
                        var versionText = "";

                        if (responseText.StartsWith("<"))
                        {
                            var responseDoc = new XmlDocument();
                            responseDoc.LoadXml(responseText);

                            var versionNode =
                                responseDoc.SelectSingleNode("//response/lst[@name='lucene']/str[@name='solr-spec-version']");

                            versionText = versionNode.InnerText;
                        }
                        else
                        {
                            var jObj = JObject.Parse(responseText);

                            var verNode = jObj.SelectToken("$..solr-spec-version");
                            versionText = verNode.ToString();
                        }

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
