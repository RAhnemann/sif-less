using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFLess.Model.Validation
{
    public class ValidatorsElement : ConfigurationElement
    {
        [ConfigurationProperty("sitecore", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ValidatorCollection))]
        public ValidatorCollection Sitecore => (ValidatorCollection)this["sitecore"];

        [ConfigurationProperty("sql", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ValidatorCollection))]
        public ValidatorCollection SQL => (ValidatorCollection)this["sql"];

        [ConfigurationProperty("solr", IsDefaultCollection = false)]
        [ConfigurationCollection(typeof(ValidatorCollection))]
        public ValidatorCollection Solr => (ValidatorCollection)this["solr"];
    }
}
