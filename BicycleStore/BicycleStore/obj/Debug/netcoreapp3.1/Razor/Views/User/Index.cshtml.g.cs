#pragma checksum "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75b84aa91c56ece82567e82f4fa31176885d3aab"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75b84aa91c56ece82567e82f4fa31176885d3aab", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<BicycleStore.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Email</th>\r\n");
#nullable restore
#line 7 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
             if (User.IsInRole("superAdmin"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>Password</th>\r\n                <th>Is Admin</th>\r\n                <th>Make admin</th>\r\n");
#nullable restore
#line 12 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>        \r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 16 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
         foreach (var it in Model)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
             if (it.RoleId != 3)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
                   Write(it.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 22 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
                     if (User.IsInRole("superAdmin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 24 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
                       Write(it.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><input type=\"checkbox\"");
            BeginWriteAttribute("checked", " checked =", 714, "", 739, 1);
#nullable restore
#line 25 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
WriteAttributeValue("", 724, it.RoleId==1, 724, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled/></td>\r\n                        <td>\r\n");
#nullable restore
#line 27 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
                             using (Html.BeginForm("Index", "User"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type =\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 941, "\"", 959, 1);
#nullable restore
#line 29 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
WriteAttributeValue("", 949, it.UserId, 949, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"UserId\" />\r\n                                <input type =\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1032, "\"", 1049, 1);
#nullable restore
#line 30 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
WriteAttributeValue("", 1040, it.Email, 1040, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Email\" />\r\n                                <input type =\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1121, "\"", 1139, 1);
#nullable restore
#line 31 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
WriteAttributeValue("", 1129, it.RoleId, 1129, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"RoleId\" />\r\n");
#nullable restore
#line 32 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
                                 if (it.RoleId == 2)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type =\"submit\" class=\"btn btn-primary\" value=\"Make admin\" />\r\n");
#nullable restore
#line 35 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"submit\" class=\"btn btn-primary\" value=\"Delete admin\" />\r\n");
#nullable restore
#line 39 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n");
#nullable restore
#line 42 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 45 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\STEP hw\BicycleShop\BicycleStore\BicycleStore\Views\User\Index.cshtml"
             

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<BicycleStore.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591