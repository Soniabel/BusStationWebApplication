#pragma checksum "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Buses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5539ab070a0060ee452ff4012308e3f44c2836d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Buses_Index), @"mvc.1.0.view", @"/Views/Buses/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5539ab070a0060ee452ff4012308e3f44c2836d9", @"/Views/Buses/Index.cshtml")]
    public class Views_Buses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusStationWebApplication.Models.Bus>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Buses\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Buses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Transporter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Buses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberOfSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Buses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BusModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Buses\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Buses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Transporter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Buses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumberOfSeats));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Buses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BusModel.BusModelID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1013, "\"", 1039, 1);
#nullable restore
#line 40 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Buses\Index.cshtml"
WriteAttributeValue("", 1028, item.BusID, 1028, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1092, "\"", 1118, 1);
#nullable restore
#line 41 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Buses\Index.cshtml"
WriteAttributeValue("", 1107, item.BusID, 1107, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1173, "\"", 1199, 1);
#nullable restore
#line 42 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Buses\Index.cshtml"
WriteAttributeValue("", 1188, item.BusID, 1188, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "D:\VisualStudio\BusStationWebApplication\BusStationWebApplication\Views\Buses\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusStationWebApplication.Models.Bus>> Html { get; private set; }
    }
}
#pragma warning restore 1591
