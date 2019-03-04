namespace ViewComponentsTest.Models.ViewComponents.Options
{
    public class MemberOrderItemListOptions : ViewComponentOptionsBase
    {
        public bool OnlyShowRedeemed { get; }

        public bool OnlyShowUnredeemed { get; }

        public int Skip { get; }

        public int Take { get; }

        public bool HideExpiredItems { get; }

        public MemberOrderItemListOptions(
            string @class,
            string style,
            bool isHidden,
            bool removeDiv,
            ElementWidths elementWidths,
            bool onlyShowUnredeemed,
            bool onlyShowRedeemed,
            int skip,
            int take,
            bool hideExpiredItems = true)
            : base(@class, style, isHidden, removeDiv, elementWidths)
        {
            this.OnlyShowUnredeemed = onlyShowUnredeemed;
            this.OnlyShowRedeemed = onlyShowRedeemed;
            this.Skip = skip;
            this.Take = take;
            this.HideExpiredItems = hideExpiredItems;
        }
    }
}
