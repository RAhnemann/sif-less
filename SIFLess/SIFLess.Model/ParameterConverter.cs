using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SIFLess.Model
{
   public class ParameterConverter : JsonConverter
    {

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);

            var paramNode = jsonObject.Properties().FirstOrDefault(p => p.Name == "Parameters");

            if (paramNode != null)
            {
                var paramsList = new ParameterList();
                List<JToken> children = ((JObject) paramNode.Value).Children().ToList();

                foreach (var param in children)
                {
                    var property = (JProperty) param;
                    
                    var paramObject = param.First.ToObject<Parameter>();

                    paramObject.Name = property.Name;

                    paramsList.Parameters.Add(paramObject);
                }

                return paramsList;
            }
           

            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(ParameterList).IsAssignableFrom(objectType);
        }
    }
}
