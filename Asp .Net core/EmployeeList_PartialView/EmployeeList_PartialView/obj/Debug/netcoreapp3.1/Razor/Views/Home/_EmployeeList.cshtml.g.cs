#pragma checksum "C:\Users\889825\source\repos\EmployeeList_PartialView\EmployeeList_PartialView\Views\Home\_EmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa5d5f9c816cf3ffb3ba6ceba2ef2ea6a7d09df1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__EmployeeList), @"mvc.1.0.view", @"/Views/Home/_EmployeeList.cshtml")]
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
#line 1 "C:\Users\889825\source\repos\EmployeeList_PartialView\EmployeeList_PartialView\Views\_ViewImports.cshtml"
using EmployeeList_PartialView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\889825\source\repos\EmployeeList_PartialView\EmployeeList_PartialView\Views\_ViewImports.cshtml"
using EmployeeList_PartialView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa5d5f9c816cf3ffb3ba6ceba2ef2ea6a7d09df1", @"/Views/Home/_EmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c08491b6debe0446e36d886938a629abc30e8a1e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__EmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeList_PartialView.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>GetEmployeeList</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\889825\source\repos\EmployeeList_PartialView\EmployeeList_PartialView\Views\Home\_EmployeeList.cshtml"
 foreach (var item in Model)
{
    if (item.IsPermanent == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <span class=\"col-md-4\"><b>");
#nullable restore
#line 13 "C:\Users\889825\source\repos\EmployeeList_PartialView\EmployeeList_PartialView\Views\Home\_EmployeeList.cshtml"
                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 13 "C:\Users\889825\source\repos\EmployeeList_PartialView\EmployeeList_PartialView\Views\Home\_EmployeeList.cshtml"
                                              Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></span>\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\889825\source\repos\EmployeeList_PartialView\EmployeeList_PartialView\Views\Home\_EmployeeList.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <span class=\"col-md-4\">");
#nullable restore
#line 19 "C:\Users\889825\source\repos\EmployeeList_PartialView\EmployeeList_PartialView\Views\Home\_EmployeeList.cshtml"
                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 19 "C:\Users\889825\source\repos\EmployeeList_PartialView\EmployeeList_PartialView\Views\Home\_EmployeeList.cshtml"
                                           Write(item.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </span>\r\n        </div>\r\n");
#nullable restore
#line 21 "C:\Users\889825\source\repos\EmployeeList_PartialView\EmployeeList_PartialView\Views\Home\_EmployeeList.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeList_PartialView.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591