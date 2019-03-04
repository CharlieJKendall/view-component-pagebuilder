namespace ViewComponentsTest.Models.ViewComponents.Options
{
    public class MemberOrderItemDetailsOptions : ViewComponentOptionsBase
    {
        public string SelectedProperty { get; }

        public string DateFormat { get; }

        public MemberOrderItemDetailsOptions(
            string @class,
            string style,
            bool isHidden,
            bool removeDiv,
            ElementWidths elementWidths,
            string selectedProperty,
            string dateFormat = null)
            : base(@class, style, isHidden, removeDiv, elementWidths)
        {
            this.SelectedProperty = selectedProperty;
            this.DateFormat = dateFormat;
        }
    }
}
