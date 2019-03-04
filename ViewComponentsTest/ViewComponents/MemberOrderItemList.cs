using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViewComponentsTest.Models.DataModels;
using ViewComponentsTest.Models.ViewComponents;

namespace ViewComponentsTest.ViewComponents
{
    public class MemberOrderItemList : ViewComponentBase, IDataProviderViewComponent<List<MemberOrderItemModel>>
    {
        public string DataProvidedTypeName => nameof(List<MemberOrderItemModel>);

        public async Task<IViewComponentResult> InvokeAsync(ViewComponentContainer viewComponent)
        {
            // Mimic data retrieval - will be exactly the same as is on the controller currently
            var memberOrders = new List<MemberOrderItemModel>()
            {
                new MemberOrderItemModel(1, VoucherRedemptionStatus.Redeemed, "A short description 1", "", "Product number 1", 545, DateTime.Now.AddDays(7)),
                new MemberOrderItemModel(2, VoucherRedemptionStatus.Unredeemed, "A short description 2", "", "Product number 2", 342, DateTime.Now.AddDays(47)),
                new MemberOrderItemModel(3, VoucherRedemptionStatus.Redeemed, "A short description 3", "", "Product number 3", 342, DateTime.Now.AddDays(-87)),
                new MemberOrderItemModel(4, VoucherRedemptionStatus.Unredeemed, "A short description 4", "", "Product number 4", 342, DateTime.Now.AddDays(57)),
                new MemberOrderItemModel(5, VoucherRedemptionStatus.Redeemed, "A short description 5", "", "Product number 5", 342, DateTime.Now.AddDays(723)),
                new MemberOrderItemModel(6, VoucherRedemptionStatus.Unredeemed, "A short description 6", "", "Product number 6", 342, DateTime.Now.AddDays(72)),
                new MemberOrderItemModel(7, VoucherRedemptionStatus.Unredeemed, "A short description 7", "", "Product number 7", 342, DateTime.Now.AddDays(-17)),
            };

            return View(new ViewComponentDataContainer<List<MemberOrderItemModel>>(viewComponent, memberOrders));
        }
    }
}
