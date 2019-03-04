using Newtonsoft.Json;
using ViewComponentsTest.Models.ViewComponents;

namespace ViewComponentsTest
{
    public class JsonSerlializer
    {
        public static MasterViewComponentModel DeserializePageJson(string json)
        {
            return JsonConvert.DeserializeObject<MasterViewComponentModel>(json);
        }

        public static string SerializePageJson(MasterViewComponentModel json)
        {
            return JsonConvert.SerializeObject(json);
        }
    }
}
