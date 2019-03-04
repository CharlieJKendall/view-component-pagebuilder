namespace ViewComponentsTest.Models.ViewComponents.Options
{
    public class HtmlElementOptions : ViewComponentOptionsBase
    {
        public string HtmlElement { get; }

        public HtmlElementOptions(string @class, string style, bool isHidden, bool removeDiv, ElementWidths elementWidths, string htmlElement)
            : base(@class, style, isHidden, removeDiv, elementWidths)
        {
            this.HtmlElement = htmlElement;
        }
    }
}
