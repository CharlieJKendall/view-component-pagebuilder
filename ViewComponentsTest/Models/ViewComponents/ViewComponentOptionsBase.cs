using System;

namespace ViewComponentsTest.Models.ViewComponents
{
    public abstract class ViewComponentOptionsBase
    {
        public string Style { get; }

        public string Class { get; }

        public ViewComponentOptionsBase(string @class, string style)
        {
            this.Class = @class;
            this.Style = style;
        }
    }
}
