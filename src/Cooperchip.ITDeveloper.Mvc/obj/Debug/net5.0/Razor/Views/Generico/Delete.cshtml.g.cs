#pragma checksum "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fdbbe2dcbf1be251c0148e5ced4a642d9f2a628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Generico_Delete), @"mvc.1.0.view", @"/Views/Generico/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fdbbe2dcbf1be251c0148e5ced4a642d9f2a628", @"/Views/Generico/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66681e992fd8d026c34daa0f70b2fc22366adfff", @"/Views/_ViewImports.cshtml")]
    public class Views_Generico_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cooperchip.ITDeveloper.Domain.Models.Generico>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Delete.cshtml"
   ViewBag.Title = "Exclusão de Genérico"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 6 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Delete.cshtml"
   Layout = null; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal-dialog"">
    <div class=""modal-content"">
        <div class=""modal-header"">
            <button type=""button"" class=""close"" data-dismiss=""modal""><span aria-hidden=""true"">×</span><span class=""sr-only"">Close</span></button>
            <h4 class=""modal-title"">MedicalManagement-Sys - ");
#nullable restore
#line 12 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Delete.cshtml"
                                                       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        </div>\n        <div class=\"modal-body\">\n            <div class=\"form-horizontal\">\n\n                <div class=\"alert alert-danger\">\n                    <h4>Confirma a exclusão do Genérico: ");
#nullable restore
#line 18 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Delete.cshtml"
                                                    Write(Model.Nome.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n                    <hr />\n");
#nullable restore
#line 20 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Delete.cshtml"
                     using (Html.BeginForm())
                    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-actions no-color\">\n                            <input type=\"submit\" value=\"Sim\" class=\"btn btn-danger\" />\n                        </div>");
#nullable restore
#line 26 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Delete.cshtml"
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>

            </div>
        </div>
        <div class=""modal-footer"">
            <input type=""button"" value=""Cancelar"" class=""btn btn-default"" data-dismiss=""modal"" />
        </div>

    </div><!-- /.modal-content -->
</div><!-- /.modal-dialog -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cooperchip.ITDeveloper.Domain.Models.Generico> Html { get; private set; }
    }
}
#pragma warning restore 1591
