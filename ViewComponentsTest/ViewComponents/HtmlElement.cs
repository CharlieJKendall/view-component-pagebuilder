using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ViewComponentsTest.Models.ViewComponents;

namespace ViewComponentsTest.ViewComponents
{
    public class HtmlElement : ViewComponentBase, IDataConsumerViewComponent<object>, IDataProviderViewComponent<object>
    {
        public string DataProvidedTypeName => nameof(Object);

        public string DataConsumedTypeName => nameof(Object);

        public async Task<IViewComponentResult> InvokeAsync(ViewComponentDataContainer<object> viewComponent)
        {
            return View(viewComponent);
        }
    }
}
