using Newtonsoft.Json;
using System.Collections.Generic;
using ViewComponentsTest.Models.ViewComponents;

namespace ViewComponentsTest
{
    public class JsonSerlializer
    {
        public static List<ViewComponentContainer> DeserializePageJson(string json)
        {
            return JsonConvert.DeserializeObject<List<ViewComponentContainer>>(json);
        }

        public static string SerializePageJson(List<ViewComponentContainer> json)
        {
            return JsonConvert.SerializeObject(json);
        }
    }
}
