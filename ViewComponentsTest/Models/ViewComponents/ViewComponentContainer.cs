using Newtonsoft.Json;
using System.Collections.Generic;

namespace ViewComponentsTest.Models.ViewComponents
{
    public class ViewComponentContainer
    {
        public IEnumerable<ViewComponentContainer> ChildViewComponents { get; }

        public string ViewComponentName { get; }

        [JsonProperty(TypeNameHandling = TypeNameHandling.All)]
        public ViewComponentOptionsBase Options { get; }

        public ViewComponentContainer(string viewComponentName, IEnumerable<ViewComponentContainer> childViewComponents, ViewComponentOptionsBase options)
        {
            this.ViewComponentName = viewComponentName;
            this.ChildViewComponents = childViewComponents ?? new List<ViewComponentContainer>();
            this.Options = options;
        }
    }
}
