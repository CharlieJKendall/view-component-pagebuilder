using System;
using System.Collections.Generic;
using ViewComponentsTest;
using ViewComponentsTest.Models.DataModels;
using ViewComponentsTest.Models.ViewComponents;
using ViewComponentsTest.Models.ViewComponents.Options;
using ViewComponentsTest.ViewComponents;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var master = new MasterViewComponentModel(
                new List<ViewComponentContainer>()
                {
                    new ViewComponentContainer(
                        nameof(MemberOrderItemList),
                        new List<ViewComponentContainer>()
                        {
                            new ViewComponentContainer(
                                nameof(MemberOrderItemRedeemedConditional),
                                new List<ViewComponentContainer>()
                                {
                                    new ViewComponentContainer(
                                        nameof(MemberOrderItemDetails),
                                        null,
                                        new MemberOrderItemDetailsOptions("a-class", "background-color:red;", false, false, new ElementWidths(1, 2, 3), nameof(MemberOrderItemModel.ProductName))),
                                    new ViewComponentContainer(
                                        nameof(MemberOrderItemDetails),
                                        null,
                                        new MemberOrderItemDetailsOptions("a-class", "background-color:white;", false, false, new ElementWidths(1, 2, 3), nameof(MemberOrderItemModel.GameNumber))),
                                    new ViewComponentContainer(
                                        nameof(MemberOrderItemExpirationCountdown),
                                        null,
                                        new MemberOrderItemExpirationCountdownOptions("a-class", "background-color:red;", false, false, new ElementWidths(1, 2, 3), significant: 4)),
                                    new ViewComponentContainer(
                                        nameof(HtmlElement),
                                        new List<ViewComponentContainer>()
                                        {
                                            new ViewComponentContainer(
                                            nameof(MemberOrderItemDetails),
                                            null,
                                            new MemberOrderItemDetailsOptions("z-class", "background-color:orange;", false, false, new ElementWidths(1, 2, 3), nameof(MemberOrderItemModel.GameNumber))),
                                        },
                                        new HtmlElementOptions("my-div-class", "padding:20px;", false, false, new ElementWidths(1, 2, 3), "div"))
                                },
                                new MemberOrderItemRedeemedConditionalOptions("redeemed-class", "padding:2px", false, false, new ElementWidths(6, 10, 12), true))                            
                        },
                        new MemberOrderItemListOptions("b-class", "background-color:blue;", false, false, new ElementWidths(3, 5, 9), false, false, 1, 1))
                },
                new List<JavascriptBundle>() { JavascriptBundle.JQuery, JavascriptBundle.JQueryPlugin, JavascriptBundle.Custom, JavascriptBundle.JQueryCountdown, JavascriptBundle.FortressMemberOrderCountdown },
                new List<CssBundle>() { CssBundle.Bootstrap });

            var json = JsonSerlializer.SerializePageJson(master);
            var result = JsonSerlializer.DeserializePageJson(json);

            Console.ReadLine();
        }
    }
}
