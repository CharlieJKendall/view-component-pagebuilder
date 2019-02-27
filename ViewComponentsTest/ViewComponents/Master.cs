using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ViewComponentsTest.ViewComponents
{
    public class Master : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(JsonSerlializer.DeserializePageJson(@"[{""ChildViewComponents"":[{""ChildViewComponents"":[{""ChildViewComponents"":[],""ViewComponentName"":""BasicText"",""Options"":{""$type"":""ViewComponentsTest.Models.ViewComponents.Options.BasicTextOptions, ViewComponentsTest"",""Style"":""background-color:blue;"",""Class"":""text-options""}}],""ViewComponentName"":""CustomerNameDisplay"",""Options"":{""$type"":""ViewComponentsTest.Models.ViewComponents.Options.CustomerNameDisplayOptions, ViewComponentsTest"",""FontSize"":50,""SelectedProperty"":""FirstName"",""Style"":""background-color:red;"",""Class"":""customer-name-display""}}],""ViewComponentName"":""CustomerDetails"",""Options"":{""$type"":""ViewComponentsTest.Models.ViewComponents.Options.CustomerDetailsOptions, ViewComponentsTest"",""ShowOlderThanEighteenOnly"":false,""Style"":""background-color:black;color:red;"",""Class"":""customer-details""}}]"));
        }
    }
}
