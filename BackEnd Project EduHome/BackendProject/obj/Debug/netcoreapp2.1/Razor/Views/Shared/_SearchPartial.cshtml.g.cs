#pragma checksum "C:\Users\Admin\source\repos\BackendProject\BackendProject\Views\Shared\_SearchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c698f21fddb9cd561107e7391c0ceb4fd4ddef2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SearchPartial), @"mvc.1.0.view", @"/Views/Shared/_SearchPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SearchPartial.cshtml", typeof(AspNetCore.Views_Shared__SearchPartial))]
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
#line 1 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Views\_ViewImports.cshtml"
using BackendProject.Models;

#line default
#line hidden
#line 2 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Views\_ViewImports.cshtml"
using BackendProject.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c698f21fddb9cd561107e7391c0ceb4fd4ddef2e", @"/Views/Shared/_SearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b719f3cb35e1953dd5283c813fb4675bf6f839b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Teacher>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Views\Shared\_SearchPartial.cshtml"
 foreach (Teacher teacher in Model)
{

#line default
#line hidden
            BeginContext(64, 42, true);
            WriteLiteral("    <li style=\"display:flex\" >\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", "  href=\"", 106, "\"", 141, 2);
            WriteAttributeValue("", 114, "/Teacher/Detail/", 114, 16, true);
#line 6 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Views\Shared\_SearchPartial.cshtml"
WriteAttributeValue("", 130, teacher.Id, 130, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(142, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(144, 16, false);
#line 6 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Views\Shared\_SearchPartial.cshtml"
                                          Write(teacher.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(160, 20, true);
            WriteLiteral("</a>\r\n    </li>   \r\n");
            EndContext();
#line 8 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Views\Shared\_SearchPartial.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
