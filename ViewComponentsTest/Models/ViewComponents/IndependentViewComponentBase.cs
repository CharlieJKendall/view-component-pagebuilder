using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ViewComponentsTest.Models.ViewComponents
{
    public abstract class IndependentViewComponentBase : ViewComponent
    {
        public abstract Task<IViewComponentResult> InvokeAsync(ViewComponentContainer viewComponent);
    }
}
