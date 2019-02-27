using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ViewComponentsTest.Models.ViewComponents;

namespace ViewComponentsTest.ViewComponents
{
    public class BasicText : ViewComponent, IDataConsumerViewComponent<String>
    {
        public string DataConsumedTypeName => nameof(String);

        public async Task<IViewComponentResult> InvokeAsync(ViewComponentDataContainer<String> viewComponent)
        {
            return View(viewComponent);
        }
    }
}
