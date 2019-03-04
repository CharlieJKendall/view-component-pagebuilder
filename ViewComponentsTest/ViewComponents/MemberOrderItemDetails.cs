using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponentsTest.Models.DataModels;
using ViewComponentsTest.Models.ViewComponents;
using ViewComponentsTest.Models.ViewComponents.Options;

namespace ViewComponentsTest.ViewComponents
{
    public class MemberOrderItemDetails : ViewComponentBase, IDataConsumerViewComponent<MemberOrderItemModel>, IDataProviderViewComponent<string>
    {
        public string DataConsumedTypeName => nameof(MemberOrderItemModel);

        public string DataProvidedTypeName => throw new NotImplementedException();

        public async Task<IViewComponentResult> InvokeAsync(ViewComponentDataContainer<MemberOrderItemModel> viewComponent)
        {
            MemberOrderItemDetailsOptions options = viewComponent.ViewComponentContainer.Options as MemberOrderItemDetailsOptions;
            string propertyValue = base.GetPropertyValueString<MemberOrderItemModel>(viewComponent.Data, options.SelectedProperty);
            return View(new ViewComponentDataContainer<string>(viewComponent.ViewComponentContainer, propertyValue));
        }
    }
}
