using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViewComponentsTest.Models.DataModels;
using ViewComponentsTest.ViewComponents;

namespace ViewComponentsTest.Models.ViewComponents
{
    [HtmlTargetElement("render-child-components", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class RenderChildComponentsDataTagHelper : TagHelper
    {
        private readonly DefaultViewComponentHelper _componentHelper;

        [HtmlAttributeName("child-view-components")]
        public IEnumerable<ViewComponentContainer> ChildViewComponents { get; set; }

        [ViewContext] // Automatically injects the view context from razor
        public ViewContext ViewContext { get; set; }

        [HtmlAttributeName("data")]
        public object Data { get; set; }

        public RenderChildComponentsDataTagHelper(IViewComponentHelper componentHelper)
        {
            _componentHelper = componentHelper as DefaultViewComponentHelper;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div-beast";
            _componentHelper.Contextualize(ViewContext);

            foreach (ViewComponentContainer viewComponentContainer in ChildViewComponents)
            {
                output.Content.AppendHtml(
                    await _componentHelper.InvokeAsync(viewComponentContainer.ViewComponentName, this.GetViewComponentData(viewComponentContainer)));
            }
        }

        private object GetViewComponentData(ViewComponentContainer viewComponentContainer)
        {
            switch (viewComponentContainer.ViewComponentName)
            {
                case nameof(MemberOrderItemDetails):
                case nameof(MemberOrderItemExpirationCountdown):
                case nameof(MemberOrderItemRedeemedConditional):
                    return new ViewComponentDataContainer<MemberOrderItemModel>(viewComponentContainer, Data as MemberOrderItemModel);
                case nameof(HtmlElement):
                    return new ViewComponentDataContainer<object>(viewComponentContainer, Data);
                default:
                    throw new ArgumentException("Invalid component");
            }
        }
    }
}
