using Newtonsoft.Json;

namespace SIFLess.Model
{
    public class Parameter
    {
        public string Name { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("DefaultValue")]
        public string DefaultValue { get; set; }

        public string Value { get; set; }
    }
}
