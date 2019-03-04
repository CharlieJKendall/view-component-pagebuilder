namespace ViewComponentsTest.Models.ViewComponents.Options
{
    public class MemberOrderItemRedeemedConditionalOptions : ViewComponentOptionsBase
    {
        public bool Not { get; }

        public MemberOrderItemRedeemedConditionalOptions(
            string @class,
            string style,
            bool isHidden,
            bool removeDiv,
            ElementWidths elementWidths,
            bool not = false)
            : base(@class, style, isHidden, removeDiv, elementWidths)
        {
            this.Not = not;
        }
    }
}
