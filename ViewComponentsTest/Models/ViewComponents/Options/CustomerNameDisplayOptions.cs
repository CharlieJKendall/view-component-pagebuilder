namespace ViewComponentsTest.Models.ViewComponents.Options
{
    public class CustomerNameDisplayOptions : ViewComponentOptionsBase
    {
        public int FontSize { get; }

        public string SelectedProperty { get; }

        public CustomerNameDisplayOptions(string @class, string style, int fontSize, string selectedProperty)
            : base(@class, style)
        {
            this.FontSize = fontSize;
            this.SelectedProperty = selectedProperty;
        }
    }
}
