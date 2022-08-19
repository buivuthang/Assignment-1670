#pragma checksum "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62857185802112c49864392d96845f910fbd8fe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Cart), @"mvc.1.0.view", @"/Views/Cart/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62857185802112c49864392d96845f910fbd8fe4", @"/Views/Cart/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12290ae8b54fdba546f13d1190a2a2d1619f6758", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Assignment.Models.CartItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("min", new global::Microsoft.AspNetCore.Html.HtmlString("1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "removecart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MakeOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Shopping Cart</h2>\r\n");
#nullable restore
#line 4 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
 if (@TempData["Message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-danger\">");
#nullable restore
#line 6 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
                             Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
 if (Model.Count > 0)
{
    double total = 0;
    int number = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Book</th>\r\n            <th>Price</th>\r\n            <th>Quantity</th>\r\n            <th>Sub-Total</th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
         foreach (var cartitem in Model)
        {
            var amount = cartitem.quantity * cartitem.book.Price;
            total += amount;


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
                Write(number++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
               Write(cartitem.book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
               Write(cartitem.book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62857185802112c49864392d96845f910fbd8fe47405", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 31 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => cartitem.quantity);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
AddHtmlAttributeValue("", 824, $"quantity-{cartitem.book.Id}", 824, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "max", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
AddHtmlAttributeValue("", 872, cartitem.book.Quantity, 872, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
               Write(amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button class=\"btn btn-success updatecartitem\"\r\n                    data-bookid=\"");
#nullable restore
#line 35 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
                            Write(cartitem.book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        Update\r\n                    </button>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62857185802112c49864392d96845f910fbd8fe410530", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-bookid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
                                                    WriteLiteral(cartitem.book.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-bookid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["bookid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td colspan=\"4\" class=\"text-right\">Total Price</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
           Write(total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n        </tr>\r\n    </table>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62857185802112c49864392d96845f910fbd8fe413436", async() => {
                WriteLiteral(@"
        <input type=""hidden"" name=""id"" />
        <input type=""hidden"" name=""id"" />
        <div class=""form-group mt-3"">
            <input type=""submit"" class=""btn btn-success"" value=""Purchase""
               onclick=""    return confirm('Are you sure to request this order ?');"" />
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function() {
            $("".updatecartitem"").click(function(event) {
                event.preventDefault();
                var bookid = $(this).attr(""data-bookid"");
                var quantity = $(""#quantity-"" + bookid).val();
                $.ajax({
                    type: ""POST"",
                    url: """);
#nullable restore
#line 68 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
                     Write(Url.RouteUrl("updatecart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                    data: {\r\n                        bookid: bookid,\r\n                        quantity: quantity\r\n                    },\r\n                    success: function(result) {\r\n                        window.location.href = \"");
#nullable restore
#line 74 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
                                           Write(Url.RouteUrl("cart"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                    }\r\n                });\r\n            });\r\n        });\r\n    </script>\r\n    ");
            }
            );
#nullable restore
#line 80 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
     

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-danger\">No product added !</p>\r\n");
#nullable restore
#line 86 "C:\Users\hieupc\source\repos\Assignment-1670\Views\Cart\Cart.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Assignment.Models.CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
