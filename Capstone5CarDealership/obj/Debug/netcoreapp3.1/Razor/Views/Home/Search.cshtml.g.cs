#pragma checksum "C:\Users\kyle\source\repos\Capstone5CarDealership\Capstone5CarDealership\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f18cf3ba3a0082a6444ec481f83d28f2257d2d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\kyle\source\repos\Capstone5CarDealership\Capstone5CarDealership\Views\_ViewImports.cshtml"
using Capstone5CarDealership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kyle\source\repos\Capstone5CarDealership\Capstone5CarDealership\Views\_ViewImports.cshtml"
using Capstone5CarDealership.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f18cf3ba3a0082a6444ec481f83d28f2257d2d2", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a53566c447998c4a76743cf8c7f4d90da603d1c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cars>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Make</th>\r\n            <th>Model</th>\r\n            <th>Year</th>\r\n            <th>Color</th>\r\n        </tr>\r\n");
#nullable restore
#line 10 "C:\Users\kyle\source\repos\Capstone5CarDealership\Capstone5CarDealership\Views\Home\Search.cshtml"
     foreach (Cars c in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\kyle\source\repos\Capstone5CarDealership\Capstone5CarDealership\Views\Home\Search.cshtml"
           Write(c.Make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\kyle\source\repos\Capstone5CarDealership\Capstone5CarDealership\Views\Home\Search.cshtml"
           Write(c.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\kyle\source\repos\Capstone5CarDealership\Capstone5CarDealership\Views\Home\Search.cshtml"
           Write(c.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\kyle\source\repos\Capstone5CarDealership\Capstone5CarDealership\Views\Home\Search.cshtml"
           Write(c.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 18 "C:\Users\kyle\source\repos\Capstone5CarDealership\Capstone5CarDealership\Views\Home\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n       ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cars>> Html { get; private set; }
    }
}
#pragma warning restore 1591
