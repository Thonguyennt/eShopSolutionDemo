#pragma checksum "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eae5c2b4e26080d74a2c3f17e6dd66433ef12ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Pager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Pager/Default.cshtml")]
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
#line 1 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\_ViewImports.cshtml"
using eShopSolutionAdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\_ViewImports.cshtml"
using eShopSolutionAdminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eae5c2b4e26080d74a2c3f17e6dd66433ef12ba", @"/Views/Shared/Components/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"020b41d1c10515d2bb0f3ceba1aeb29013e14b4c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eShopSolution.ViewModels.Common.PagedResultBase>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
  
    var urlTemplate = Url.Action() + "?pageIndex={0}";
    var request = ViewContext.HttpContext.Request;
    foreach (var key in request.Query.Keys)
    {
        if (key == "pageIndex")
        {   
            continue;
        }
        if (request.Query[key].Count > 1)
        {
            foreach (var item in (string[])request.Query[key])
            {
                urlTemplate += "&" + key + "=" + item;
            }
        }
        else
        {
            urlTemplate += "&" + key + "=" + request.Query[key];
        }
    }

    var startIndex = Math.Max(Model.PageIndex - 5, 1);
    var finishIndex = Math.Min(Model.PageIndex + 5, Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 28 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
 if (Model.PageCount > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"pagination\">\r\n");
#nullable restore
#line 31 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != startIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\" title=\"1\"");
            BeginWriteAttribute("href", " href=\"", 956, "\"", 995, 1);
#nullable restore
#line 34 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 963, urlTemplate.Replace("{0}", "1"), 963, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Đầu</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1097, "\"", 1163, 1);
#nullable restore
#line 37 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1104, urlTemplate.Replace("{0}", (Model.PageIndex-1).ToString()), 1104, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trước</a>\r\n            </li>\r\n");
#nullable restore
#line 39 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
         for (var i = startIndex; i <= finishIndex; i++)
        {
            if (i == Model.PageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item active\">\r\n                    <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 45 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\r\n                </li>\r\n");
#nullable restore
#line 47 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1602, "\"", 1629, 2);
            WriteAttributeValue("", 1610, "Trang", 1610, 5, true);
#nullable restore
#line 50 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue(" ", 1615, i.ToString(), 1616, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1630, "\"", 1678, 1);
#nullable restore
#line 50 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1637, urlTemplate.Replace("{0}", i.ToString()), 1637, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 50 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 51 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
         if (Model.PageIndex != finishIndex)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("title", " title=\"", 1848, "\"", 1883, 1);
#nullable restore
#line 56 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1856, Model.PageCount.ToString(), 1856, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 1884, "\"", 1950, 1);
#nullable restore
#line 56 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 1891, urlTemplate.Replace("{0}", (Model.PageIndex+1).ToString()), 1891, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sau</a>\r\n            </li>\r\n            <li class=\"page-item\">\r\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2052, "\"", 2114, 1);
#nullable restore
#line 59 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
WriteAttributeValue("", 2059, urlTemplate.Replace("{0}", Model.PageCount.ToString()), 2059, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cuối</a>\r\n            </li>\r\n");
#nullable restore
#line 61 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n");
#nullable restore
#line 63 "D:\Hoc-demo\C#\demo2\eShopSolution\eShopSolutionAdminApp\Views\Shared\Components\Pager\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eShopSolution.ViewModels.Common.PagedResultBase> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
