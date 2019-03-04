﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ViewComponentsTest.ViewComponents
{
    public class Master : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(JsonSerlializer.DeserializePageJson(@"{""ViewComponents"":[{""ChildViewComponents"":[{""ChildViewComponents"":[{""ChildViewComponents"":[],""ViewComponentName"":""MemberOrderItemDetails"",""Options"":{""$type"":""ViewComponentsTest.Models.ViewComponents.Options.MemberOrderItemDetailsOptions, ViewComponentsTest"",""SelectedProperty"":""ProductName"",""DateFormat"":null,""Style"":""background-color:red;"",""Class"":""a-class"",""IsHidden"":false,""RemoveDiv"":false,""ElementWidths"":{""Small"":1,""Medium"":2,""Large"":3}}},{""ChildViewComponents"":[],""ViewComponentName"":""MemberOrderItemDetails"",""Options"":{""$type"":""ViewComponentsTest.Models.ViewComponents.Options.MemberOrderItemDetailsOptions, ViewComponentsTest"",""SelectedProperty"":""GameNumber"",""DateFormat"":null,""Style"":""background-color:white;"",""Class"":""a-class"",""IsHidden"":false,""RemoveDiv"":false,""ElementWidths"":{""Small"":1,""Medium"":2,""Large"":3}}},{""ChildViewComponents"":[],""ViewComponentName"":""MemberOrderItemExpirationCountdown"",""Options"":{""$type"":""ViewComponentsTest.Models.ViewComponents.Options.MemberOrderItemExpirationCountdownOptions, ViewComponentsTest"",""Layout"":""{o<} {on} {ol} {o>} {w<} {wn} {wl} {w>} {d<} {dn} {dl} {d>} {h<} {hn} {hl} {h>} {m<} {mn} {ml} {m>} {s<} {sn} {sl} {s>}"",""Significant"":4,""Format"":""dhms"",""Style"":""background-color:red;"",""Class"":""a-class"",""IsHidden"":false,""RemoveDiv"":false,""ElementWidths"":{""Small"":1,""Medium"":2,""Large"":3}}},{""ChildViewComponents"":[{""ChildViewComponents"":[],""ViewComponentName"":""MemberOrderItemDetails"",""Options"":{""$type"":""ViewComponentsTest.Models.ViewComponents.Options.MemberOrderItemDetailsOptions, ViewComponentsTest"",""SelectedProperty"":""GameNumber"",""DateFormat"":null,""Style"":""background-color:orange;"",""Class"":""z-class"",""IsHidden"":false,""RemoveDiv"":false,""ElementWidths"":{""Small"":1,""Medium"":2,""Large"":3}}}],""ViewComponentName"":""HtmlElement"",""Options"":{""$type"":""ViewComponentsTest.Models.ViewComponents.Options.HtmlElementOptions, ViewComponentsTest"",""HtmlElement"":""div"",""Style"":""padding:20px;"",""Class"":""my-div-class"",""IsHidden"":false,""RemoveDiv"":false,""ElementWidths"":{""Small"":1,""Medium"":2,""Large"":3}}}],""ViewComponentName"":""MemberOrderItemRedeemedConditional"",""Options"":{""$type"":""ViewComponentsTest.Models.ViewComponents.Options.MemberOrderItemRedeemedConditionalOptions, ViewComponentsTest"",""Not"":true,""Style"":""padding:2px"",""Class"":""redeemed-class"",""IsHidden"":false,""RemoveDiv"":false,""ElementWidths"":{""Small"":6,""Medium"":10,""Large"":12}}}],""ViewComponentName"":""MemberOrderItemList"",""Options"":{""$type"":""ViewComponentsTest.Models.ViewComponents.Options.MemberOrderItemListOptions, ViewComponentsTest"",""OnlyShowRedeemed"":false,""OnlyShowUnredeemed"":false,""Skip"":1,""Take"":1,""HideExpiredItems"":true,""Style"":""background-color:blue;"",""Class"":""b-class"",""IsHidden"":false,""RemoveDiv"":false,""ElementWidths"":{""Small"":3,""Medium"":5,""Large"":9}}}],""JavascriptBundles"":[1,6,3,4,5],""CssBundles"":[1]}"));
        }
    }
}
