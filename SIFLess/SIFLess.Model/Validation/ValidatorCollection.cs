using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIFLess.Model.Validation
{
    public class ValidatorCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ValidatorType();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ValidatorType) element).Type;
        }

        public override ConfigurationElementCollectionType CollectionType => ConfigurationElementCollectionType.AddRemoveClearMap;

        public ValidatorType this[int index]
        {
            get => BaseGet(index) as ValidatorType;
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        public new ValidatorType this[string Name] => (ValidatorType)BaseGet(Name);

       
    }
}
