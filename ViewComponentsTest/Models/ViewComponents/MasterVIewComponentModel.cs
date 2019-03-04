using System.Collections.Generic;

namespace ViewComponentsTest.Models.ViewComponents
{
    public class MasterViewComponentModel
    {
        public IEnumerable<ViewComponentContainer> ViewComponents { get; set; }

        public IEnumerable<JavascriptBundle> JavascriptBundles { get; set; }

        public IEnumerable<CssBundle> CssBundles { get; set; }

        public MasterViewComponentModel(
            IEnumerable<ViewComponentContainer> viewComponents,
            IEnumerable<JavascriptBundle> javascriptBundles,
            IEnumerable<CssBundle> cssBundles)
        {
            this.ViewComponents = viewComponents;
            this.JavascriptBundles = javascriptBundles;
            this.CssBundles = cssBundles;
        }
    }
}
