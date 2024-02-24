#pragma checksum "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59c533fd9ada0c8c2400ed003cbb135d3f878c5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
#line 2 "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59c533fd9ada0c8c2400ed003cbb135d3f878c5d", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a37584fdbe64ca31cd20fae569eeb6d30eee5e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"  <div class=""navbar bg-danger navbar-dark navbar-expand-sm"">
        <div class=""container"">
            <a href=""/"" class=""navbar-brand"">Shopapp</a>
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item"">
                    <a href=""/products"" class=""nav-link"">Products</a>
                </li>

");
#nullable restore
#line 9 "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                 if(User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a href=\"/cart\" class=\"nav-link\">Cart</a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 611, "\"", 618, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">Orders</a>\r\n                    </li>    \r\n");
#nullable restore
#line 17 "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                    if(User.IsInRole("admin")){

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                        <a href=""/admin/products"" class=""nav-link"">Admin Products</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/admin/categories"" class=""nav-link"">Admin Categories</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/admin/role/list"" class=""nav-link"">Roles</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/admin/user/list"" class=""nav-link"">Users</a>
                    </li>
");
#nullable restore
#line 30 "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                    }                      
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n\r\n             <ul class=\"navbar-nav ml-auto\">\r\n\r\n");
#nullable restore
#line 36 "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                 if(User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a href=\"/account/manage\" class=\"nav-link\">\r\n                            ");
#nullable restore
#line 40 "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a href=\"/account/logout\" class=\"nav-link\">Logout</a>\r\n                    </li>\r\n");
#nullable restore
#line 46 "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                }
                else
                {                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li class=""nav-item"">
                        <a href=""/account/login"" class=""nav-link"">Login</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/account/register"" class=""nav-link"">Register</a>
                    </li>    
");
#nullable restore
#line 55 "E:\Desktop\shopapp\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n\r\n\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
