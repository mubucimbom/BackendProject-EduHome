#pragma checksum "C:\Users\Admin\source\repos\BackendProject\BackendProject\Views\Shared\_SearchEventPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dadb1daeb4da4918ab04624c895c3501ec0fbb36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SearchEventPartial), @"mvc.1.0.view", @"/Views/Shared/_SearchEventPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SearchEventPartial.cshtml", typeof(AspNetCore.Views_Shared__SearchEventPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb1daeb4da4918ab04624c895c3501ec0fbb36", @"/Views/Shared/_SearchEventPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b719f3cb35e1953dd5283c813fb4675bf6f839b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SearchEventPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Event>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Views\Shared\_SearchEventPartial.cshtml"
 foreach (Event eventt in Model)
{

#line default
#line hidden
            BeginContext(59, 41, true);
            WriteLiteral("    <li style=\"display:flex\">\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 100, "\"", 131, 2);
            WriteAttributeValue("", 107, "/Event/Detail/", 107, 14, true);
#line 6 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Views\Shared\_SearchEventPartial.cshtml"
WriteAttributeValue("", 121, eventt.Id, 121, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(132, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(134, 16, false);
#line 6 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Views\Shared\_SearchEventPartial.cshtml"
                                      Write(eventt.EventName);

#line default
#line hidden
            EndContext();
            BeginContext(150, 17, true);
            WriteLiteral("</a>\r\n    </li>\r\n");
            EndContext();
#line 8 "C:\Users\Admin\source\repos\BackendProject\BackendProject\Views\Shared\_SearchEventPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Event>> Html { get; private set; }
    }
}
#pragma warning restore 1591