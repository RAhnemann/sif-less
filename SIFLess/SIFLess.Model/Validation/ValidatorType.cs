using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFLess.Model.Validation
{
    public class ValidatorType:ConfigurationElement
    {
        [ConfigurationProperty("type", IsRequired = true)]
        public string Type
        {
            get => (string)this["type"];
            set => this["type"] = value;
        }
    }
}
