#pragma checksum "E:\MicroServices\TestJson\TestConvertJson\WebMVC\Views\Home\Weather.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f2a3cc30e4fd91dc301efe893d66ce9c3fed9c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Weather), @"mvc.1.0.view", @"/Views/Home/Weather.cshtml")]
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
#nullable restore
#line 1 "E:\MicroServices\TestJson\TestConvertJson\WebMVC\Views\_ViewImports.cshtml"
using WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MicroServices\TestJson\TestConvertJson\WebMVC\Views\_ViewImports.cshtml"
using WebMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f2a3cc30e4fd91dc301efe893d66ce9c3fed9c8", @"/Views/Home/Weather.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d07e873f05b36c9d83cd6a184d4bfbe1720fee4b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Weather : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WebMVC.Models.WeatherData>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\MicroServices\TestJson\TestConvertJson\WebMVC\Views\Home\Weather.cshtml"
  
    ViewBag.Title = "Weather";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Weather</h2>\r\n\r\n<table>\r\n");
#nullable restore
#line 11 "E:\MicroServices\TestJson\TestConvertJson\WebMVC\Views\Home\Weather.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 14 "E:\MicroServices\TestJson\TestConvertJson\WebMVC\Views\Home\Weather.cshtml"
           Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "E:\MicroServices\TestJson\TestConvertJson\WebMVC\Views\Home\Weather.cshtml"
           Write(item.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "E:\MicroServices\TestJson\TestConvertJson\WebMVC\Views\Home\Weather.cshtml"
           Write(item.TemperatureF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "E:\MicroServices\TestJson\TestConvertJson\WebMVC\Views\Home\Weather.cshtml"
           Write(item.TemperatureC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 19 "E:\MicroServices\TestJson\TestConvertJson\WebMVC\Views\Home\Weather.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WebMVC.Models.WeatherData>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
