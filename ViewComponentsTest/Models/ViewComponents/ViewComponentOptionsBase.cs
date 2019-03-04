namespace ViewComponentsTest.Models.ViewComponents
{
    public abstract class ViewComponentOptionsBase
    {
        public string Style { get; }

        public string Class { get; }

        public bool IsHidden { get; }

        public bool RemoveDiv { get; }

        public ElementWidths ElementWidths { get; }

        public ViewComponentOptionsBase(string @class, string style, bool isHidden, bool removeDiv, ElementWidths elementWidths)
        {
            this.Class = @class;
            this.Style = style;
            this.IsHidden = isHidden;
            this.RemoveDiv = removeDiv;
            this.ElementWidths = elementWidths;
        }
    }
}
