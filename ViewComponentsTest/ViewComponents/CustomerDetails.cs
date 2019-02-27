using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViewComponentsTest.Models.DataModels;
using ViewComponentsTest.Models.ViewComponents;

namespace ViewComponentsTest.ViewComponents
{
    public class CustomerDetails : ViewComponent, IDataProviderViewComponent<List<CustomerModel>>
    {
        public string DataProvidedTypeName => nameof(List<CustomerModel>);

        public async Task<IViewComponentResult> InvokeAsync(ViewComponentContainer viewComponent)
        {
            List<CustomerModel> customers = new List<CustomerModel>()
            {
                new CustomerModel("Charlie", "Kendall", new DateTime(1994, 6, 2)),
                new CustomerModel("Little Boy", "Kendall", new DateTime(1998, 6, 2)),
                new CustomerModel("Big Boy", "Kendall", new DateTime(2004, 6, 2))
            };

            var returnModel = new ViewComponentDataContainer<List<CustomerModel>>(viewComponent, customers);

            return View(returnModel);
        }
    }
}
