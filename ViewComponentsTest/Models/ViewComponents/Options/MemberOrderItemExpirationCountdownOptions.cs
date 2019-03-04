namespace ViewComponentsTest.Models.ViewComponents.Options
{
    public class MemberOrderItemExpirationCountdownOptions : ViewComponentOptionsBase
    {
        public string Layout { get; }

        public int Significant { get; }

        public string Format { get; }

        public MemberOrderItemExpirationCountdownOptions(
            string @class,
            string style,
            bool isHidden,
            bool removeDiv,
            ElementWidths elementWidths,
            string layout = "{o<} {on} {ol} {o>} {w<} {wn} {wl} {w>} {d<} {dn} {dl} {d>} {h<} {hn} {hl} {h>} {m<} {mn} {ml} {m>} {s<} {sn} {sl} {s>}",
            int significant = 3,
            string format = "dhms")
            : base(@class, style, isHidden, removeDiv, elementWidths)
        {
            this.Layout = layout;
            this.Significant = significant;
            this.Format = format;
        }
    }
}
