using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using System.Threading.Tasks;

namespace ViewComponentsTest.Models.ViewComponents
{
    [HtmlTargetElement("base-div", Attributes = nameof(Options), TagStructure = TagStructure.NormalOrSelfClosing)]
    public class BaseDivTagHelper : TagHelper
    {
        public ViewComponentOptionsBase Options { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            if (Options.IsHidden)
            {
                output.Content.AppendHtml(@"<!-- Hidden Control Not Rendered -->");
                output.Content.SetHtmlContent(string.Empty);
            }
            else if (Options.RemoveDiv)
            {
                output.Content.AppendHtml(@"<!-- Removed Div -->");
            }
            else
            {
                output.Attributes.Add("class", this.ParseWidthClasses());
            }
        }

        private string ParseWidthClasses()
        {
            StringBuilder widthClassBuilder = new StringBuilder($"columns small-{Options.ElementWidths.Small}");

            if (Options.ElementWidths.Medium != Options.ElementWidths.Small)
            {
                widthClassBuilder.Append($" medium-{Options.ElementWidths.Medium}");
            }

            if (Options.ElementWidths.Large != Options.ElementWidths.Medium)
            {
                widthClassBuilder.Append($" large-{Options.ElementWidths.Large}");
            }

            return widthClassBuilder.ToString();
        }
    }
}
