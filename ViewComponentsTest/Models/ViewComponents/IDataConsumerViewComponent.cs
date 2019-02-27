using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ViewComponentsTest.Models.ViewComponents
{
    public interface IDataConsumerViewComponent<TDataConsumed>
    {
        string DataConsumedTypeName { get; }

        Task<IViewComponentResult> InvokeAsync(ViewComponentDataContainer<TDataConsumed> viewComponent);
    }
}
