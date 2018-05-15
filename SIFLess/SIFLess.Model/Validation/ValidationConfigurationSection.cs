using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFLess.Model.Validation
{
    public class ValidationConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("validators")]
        public ValidatorsElement Validators
        {
            get => (ValidatorsElement)this["validators"];
            set => this["validators"] = value;
        }
    }
}
