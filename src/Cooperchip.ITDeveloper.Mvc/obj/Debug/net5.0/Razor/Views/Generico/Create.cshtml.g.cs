#pragma checksum "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1749606a451f039198cf464c3bbe5838e06c593f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Generico_Create), @"mvc.1.0.view", @"/Views/Generico/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1749606a451f039198cf464c3bbe5838e06c593f", @"/Views/Generico/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66681e992fd8d026c34daa0f70b2fc22366adfff", @"/Views/_ViewImports.cshtml")]
    public class Views_Generico_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cooperchip.ITDeveloper.Domain.Models.Generico>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
   ViewBag.Title = "Adicionar novo Genérico"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
   Layout = ""; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal-dialog"">
    <div class=""modal-content"">
        <div class=""modal-header"">
            <button type=""button"" class=""close"" data-dismiss=""modal""><span aria-hidden=""true"">×</span><span class=""sr-only"">Close</span></button>
            <h4 class=""modal-title"">MedicalManagement-Sys</h4>
        </div>
        <div class=""modal-body"">
            <div class=""form-horizontal"">

");
#nullable restore
#line 17 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
                 using (Html.BeginForm())
                {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-horizontal\">\n                        <h4> ");
#nullable restore
#line 22 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
                        Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\n                        <hr />\n                        ");
#nullable restore
#line 24 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
                   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 27 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
                       Write(Html.LabelFor(model => model.Codigo, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <div class=\"col-md-10\">\n                                ");
#nullable restore
#line 29 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
                           Write(Html.EditorFor(model => model.Codigo, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 30 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Codigo, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n                        </div>\n\n                        <div class=\"form-group\">\n                            ");
#nullable restore
#line 35 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
                       Write(Html.LabelFor(model => model.Nome, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <div class=\"col-md-10\">\n                                ");
#nullable restore
#line 37 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
                           Write(Html.EditorFor(model => model.Nome, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                ");
#nullable restore
#line 38 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Nome, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>



                        <div class=""form-group"">
                            <div class=""col-md-offset-2 col-md-10"">
                                <input type=""submit"" value=""Adicionar"" class=""btn btn-primary"" />
                            </div>
                        </div>
                    </div>");
#nullable restore
#line 49 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"modal-footer\">\n            <input type=\"button\" value=\"Cancelar\" class=\"btn btn-default\" data-dismiss=\"modal\" />\n        </div>\n\n    </div><!-- /.modal-content -->\n</div><!-- /.modal-dialog -->\n\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n");
#nullable restore
#line 63 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Generico\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\n");
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
