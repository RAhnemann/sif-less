using System.IO;
using System.Net;
using SIFLess.Model;
using SIFLess.Model.Profiles;
using SIFLess.Model.Validation;

namespace SIFLess.Validators.Default.Solr
{
   public class ValidFolderValidator :ISolrValidator
    {
        public string ErrorMessage { get; set; }
        public string Text => "Is Valid Solr Url";
        public bool Validate(SolrProfile profile)
        {
            if (!Directory.Exists(profile.CorePath))
            {
                ErrorMessage = "Core Directory doesn't exist";
                return false;
            }

            var solrxmlPath = Path.Combine(profile.CorePath.EnsureEndsWith("\\"), "server\\solr\\solr.xml");
            if (!File.Exists(solrxmlPath))
            {
                ErrorMessage = $"Couldn't find solr.xml in Core Folder: [{solrxmlPath}]";
                return false;
            }

            return true;
        }
    }
}
