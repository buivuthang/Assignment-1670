#pragma checksum "E:\GCH0904\1670\ASM2\Assignment-1670\Views\Order\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "699b64db03b15cb5d3561a3006fbfe1f7af2c26d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Detail), @"mvc.1.0.view", @"/Views/Order/Detail.cshtml")]
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
#line 1 "E:\GCH0904\1670\ASM2\Assignment-1670\Views\_ViewImports.cshtml"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GCH0904\1670\ASM2\Assignment-1670\Views\_ViewImports.cshtml"
using Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"699b64db03b15cb5d3561a3006fbfe1f7af2c26d", @"/Views/Order/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12290ae8b54fdba546f13d1190a2a2d1619f6758", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"text text-center\">Order Detail</h1>\r\n<div class=\"container col-md-6 text-center mt-3\">\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th colspan=\"4\" class=\"h3 bg-light text-success\">Order Id ");
#nullable restore
#line 7 "E:\GCH0904\1670\ASM2\Assignment-1670\Views\Order\Detail.cshtml"
                                                                 Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n        <tr>\r\n            <th>Order Detail Id</th>\r\n            <th>Book Title</th>\r\n            <th>Quantity</th>\r\n            <th>Total</th>\r\n        </tr>\r\n");
#nullable restore
#line 15 "E:\GCH0904\1670\ASM2\Assignment-1670\Views\Order\Detail.cshtml"
         foreach (var od in Model.OrderDetails)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "E:\GCH0904\1670\ASM2\Assignment-1670\Views\Order\Detail.cshtml"
               Write(od.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "E:\GCH0904\1670\ASM2\Assignment-1670\Views\Order\Detail.cshtml"
               Write(od.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "E:\GCH0904\1670\ASM2\Assignment-1670\Views\Order\Detail.cshtml"
               Write(od.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "E:\GCH0904\1670\ASM2\Assignment-1670\Views\Order\Detail.cshtml"
               Write(od.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "E:\GCH0904\1670\ASM2\Assignment-1670\Views\Order\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
