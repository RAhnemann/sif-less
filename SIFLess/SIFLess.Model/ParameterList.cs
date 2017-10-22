using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SIFLess.Model;

namespace SIFLess
{
    [JsonConverter(typeof(ParameterConverter))]
    public class ParameterList
    {
        public ParameterList()
        {
            Parameters = new List<Parameter>();
        }
        public List<Parameter> Parameters { get; set; }
    }
}
