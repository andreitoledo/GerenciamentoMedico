#pragma checksum "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\PartialViews\_footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddc58d01f9a974a472ff8402bfd7df7047b66e60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialViews__footer), @"mvc.1.0.view", @"/Views/Shared/PartialViews/_footer.cshtml")]
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
#line 1 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddc58d01f9a974a472ff8402bfd7df7047b66e60", @"/Views/Shared/PartialViews/_footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66681e992fd8d026c34daa0f70b2fc22366adfff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews__footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Cooperchip.ITDeveloper.Mvc.Extensions.TagHelpers.EmailTagHelper __Cooperchip_ITDeveloper_Mvc_Extensions_TagHelpers_EmailTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"footer\" class=\"clearfix sidebar-page right-sidebar-page\">\r\n    <!-- Start #footer  -->\r\n    <p class=\"pull-left\">\r\n        Copyrights &copy; 2022 / ");
#nullable restore
#line 5 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\PartialViews\_footer.cshtml"
                            Write(DateTime.Now.Year.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a href=\"https://github.com/andreitoledo\" class=\"color-blue strong\" target=\"_blank\">EAD IT Developer</a>. Todos os direitos reservados.\r\n    </p>\r\n    <p>\r\n        &nbsp; ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("email", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddc58d01f9a974a472ff8402bfd7df7047b66e604322", async() => {
                WriteLiteral("contato");
            }
            );
            __Cooperchip_ITDeveloper_Mvc_Extensions_TagHelpers_EmailTagHelper = CreateTagHelper<global::Cooperchip.ITDeveloper.Mvc.Extensions.TagHelpers.EmailTagHelper>();
            __tagHelperExecutionContext.Add(__Cooperchip_ITDeveloper_Mvc_Extensions_TagHelpers_EmailTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    </p>\r\n\r\n    <p class=\"pull-right\">\r\n        <a href=\"#\" class=\"mr5\">Terms of use</a>\r\n        |\r\n        <a href=\"#\" class=\"ml5 mr25\">Privacy police</a>\r\n    </p>\r\n</div>\r\n<!-- End #footer  -->");
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
