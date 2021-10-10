#pragma checksum "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec9b06aa3259a898418373966fcfb4cdb50df294"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec9b06aa3259a898418373966fcfb4cdb50df294", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BicycleStore.Models.ViewModels.BicycleIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Cart</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Quantity</th>\r\n            <th>Title</th>\r\n            <th>Model</th>\r\n            <th>Price</th>\r\n            <th>Subtotal</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 15 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
         foreach (var line in Model.Cart.Lines)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 18 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
                   Write(line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 19 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
                   Write(line.Bicycle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
                   Write(line.Bicycle.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
                   Write(line.Bicycle.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
                    Write(line.Bicycle.Price*line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 24 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
                         using (Html.BeginForm("RemoveFromCart", "Cart"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 839, "\"", 870, 1);
#nullable restore
#line 26 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 847, line.Bicycle.BicycleId, 847, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"BicycleId\" />\r\n                            <input type=\"hidden\" value=\"Home/Index\" name=\"returnUrl\" />\r\n                            <input type=\"submit\" class=\"btn btn-danger\" value=\"Delete from cart\" />\r\n");
#nullable restore
#line 29 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n");
#nullable restore
#line 31 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
                     if (line.Quantity > 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n");
#nullable restore
#line 34 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
                             using (Html.BeginForm("RemoveOneFromCart", "Cart"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1400, "\"", 1431, 1);
#nullable restore
#line 36 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1408, line.Bicycle.BicycleId, 1408, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"BicycleId\" />\r\n                                <input type=\"hidden\" value=\"Home/Index\" name=\"returnUrl\" />\r\n                                <input type=\"submit\" class=\"btn btn-warning\" value=\"Delete one from cart\" />\r\n");
#nullable restore
#line 39 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n");
#nullable restore
#line 41 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 43 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td>Total:</td>\r\n            <td>");
#nullable restore
#line 48 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
           Write(Model.Cart.ComputeTotalValue());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 1947, "\"", 1970, 1);
#nullable restore
#line 53 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1954, Model.ReturnUrl, 1954, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary\">Continue shopping</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BicycleStore.Models.ViewModels.BicycleIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
