using Microsoft.AspNetCore.Mvc;

namespace ViewComponentsTest.Models.ViewComponents
{
    public abstract class ViewComponentBase : ViewComponent
    {
        protected string GetPropertyValueString<TData>(TData data, string propertyName) => typeof(TData).GetProperty(propertyName).GetValue(data).ToString();
    }
}
