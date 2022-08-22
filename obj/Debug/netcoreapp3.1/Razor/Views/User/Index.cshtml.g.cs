#pragma checksum "C:\Users\hieupc\source\repos\Assignment-1670\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d78702b24964bc9332f2c2622680cac0579c8010"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\hieupc\source\repos\Assignment-1670\Views\_ViewImports.cshtml"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hieupc\source\repos\Assignment-1670\Views\_ViewImports.cshtml"
using Assignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d78702b24964bc9332f2c2622680cac0579c8010", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12290ae8b54fdba546f13d1190a2a2d1619f6758", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container text-center mt-3\">\r\n");
#nullable restore
#line 3 "C:\Users\hieupc\source\repos\Assignment-1670\Views\User\Index.cshtml"
     if (@TempData["Message"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"alert alert-danger\">");
#nullable restore
#line 5 "C:\Users\hieupc\source\repos\Assignment-1670\Views\User\Index.cshtml"
                                 Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 6 "C:\Users\hieupc\source\repos\Assignment-1670\Views\User\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered"">
        <tr>
            <th colspan=""6"" class=""h3 bg-light text-success"">Users List</th>
        </tr>
        <tr>
            <th>User Id</th>
            <th>Email</th>
            <th>Role</th>
        </tr>
");
#nullable restore
#line 16 "C:\Users\hieupc\source\repos\Assignment-1670\Views\User\Index.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\hieupc\source\repos\Assignment-1670\Views\User\Index.cshtml"
               Write(user.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\hieupc\source\repos\Assignment-1670\Views\User\Index.cshtml"
               Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 21 "C:\Users\hieupc\source\repos\Assignment-1670\Views\User\Index.cshtml"
                 foreach (var role in ViewBag.Roles)
                {
                    if(user.Id == role.UserId)
                    {
                        if(role.RoleId.Equals("1"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Admin</td>\r\n");
#nullable restore
#line 28 "C:\Users\hieupc\source\repos\Assignment-1670\Views\User\Index.cshtml"
                        }else if(role.RoleId.Equals("2"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Store Owner</td>\r\n");
#nullable restore
#line 31 "C:\Users\hieupc\source\repos\Assignment-1670\Views\User\Index.cshtml"
                        }else if(role.RoleId.Equals("3"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>Customer</td>\r\n");
#nullable restore
#line 34 "C:\Users\hieupc\source\repos\Assignment-1670\Views\User\Index.cshtml"
                        }
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\hieupc\source\repos\Assignment-1670\Views\User\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
