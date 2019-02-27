using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using ViewComponentsTest.Models.DataModels;
using ViewComponentsTest.Models.ViewComponents;
using ViewComponentsTest.Models.ViewComponents.Options;

namespace ViewComponentsTest.ViewComponents
{
    public class CustomerNameDisplay : ViewComponent, IDataConsumerViewComponent<CustomerModel>, IDataProviderViewComponent<string>
    {
        public string DataConsumedTypeName => nameof(CustomerModel);

        public string DataProvidedTypeName => nameof(String);

        public async Task<IViewComponentResult> InvokeAsync(ViewComponentDataContainer<CustomerModel> viewComponent)
        {
            var options = viewComponent.ViewComponentContainer.Options as CustomerNameDisplayOptions;
            var d = viewComponent.Data.GetType();
            var e = d.GetProperty(options.SelectedProperty);
            var f = e.GetValue(viewComponent.Data).ToString();

            return View(new ViewComponentDataContainer<String>(viewComponent.ViewComponentContainer, f));
        }
    }
}
