#pragma checksum "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Reservations\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e73a189bac9779a71f8ae3e61f04b28e4f92a579"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Create), @"mvc.1.0.view", @"/Views/Reservations/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e73a189bac9779a71f8ae3e61f04b28e4f92a579", @"/Views/Reservations/Create.cshtml")]
    public class Views_Reservations_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusStationWebApplication.Models.Reservation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Reservations\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Reservation</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""JourneyID"" class=""control-label""></label>
                <input asp-for=""JourneyID"" class=""form-control"" />
                <span asp-validation-for=""JourneyID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NumberOfTickets"" class=""control-label""></label>
                <input asp-for=""NumberOfTickets"" class=""form-control"" />
                <span asp-validation-for=""NumberOfTickets"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ClientID"" class=""control-label""></label>
                <select asp-for=""ClientID"" class =""form-control"" asp-items=""ViewBag.ClientID""></select>
         ");
            WriteLiteral("   </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 41 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Reservations\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusStationWebApplication.Models.Reservation> Html { get; private set; }
    }
}
#pragma warning restore 1591
