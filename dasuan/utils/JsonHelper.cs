using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dasuan.utils
{
    public class JsonHelper
    {
        public static string WriteJson<T>(string name, List<T>  content) where T : class
        {
            string jsonFile = AppDomain.CurrentDomain.BaseDirectory + $"/{name}.json";
            //var settings = new JsonSerializerSettings
            //{
            //    ContractResolver = new CamelCasePropertyNamesContractResolver()
            //};
            //JObject cycleJson = JObject.Parse(JsonConvert.SerializeObject(windConfig, settings));

            //System.IO.File.WriteAllText(jsonFile, cycleJson.ToString());
            using (System.IO.StreamWriter file = new StreamWriter(jsonFile, false))
            {
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    JArray cycleJson = JArray.Parse(JsonConvert.SerializeObject(content));
                    cycleJson.WriteTo(writer);
                }
            }
            return jsonFile;
        }
    }
}
