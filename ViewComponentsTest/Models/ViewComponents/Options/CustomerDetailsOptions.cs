using System;

namespace ViewComponentsTest.Models.ViewComponents.Options
{
    public class CustomerDetailsOptions : ViewComponentOptionsBase
    {
        public bool ShowOlderThanEighteenOnly { get; }

        public CustomerDetailsOptions(string @class, string style, bool showOlderThanEighteenOnly)
            : base(@class, style)
        {
            this.ShowOlderThanEighteenOnly = showOlderThanEighteenOnly;
        }
    }
}
