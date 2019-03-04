using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ViewComponentsTest.Models.DataModels;
using ViewComponentsTest.Models.ViewComponents;

namespace ViewComponentsTest.ViewComponents
{
    public class MemberOrderItemExpirationCountdown : ViewComponentBase, IDataConsumerViewComponent<MemberOrderItemModel>
    {
        public string DataConsumedTypeName => nameof(MemberOrderItemModel);

        public async Task<IViewComponentResult> InvokeAsync(ViewComponentDataContainer<MemberOrderItemModel> viewComponent)
        {
            return View(viewComponent);
        }
    }
}
