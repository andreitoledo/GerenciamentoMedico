#pragma checksum "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3d8fd2e48c26fcb584adc907c3bc8f60ea0d64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EstadoEstavel_Default), @"mvc.1.0.view", @"/Views/Shared/Components/EstadoEstavel/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e3d8fd2e48c26fcb584adc907c3bc8f60ea0d64", @"/Views/Shared/Components/EstadoEstavel/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66681e992fd8d026c34daa0f70b2fc22366adfff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_EstadoEstavel_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cooperchip.ITDeveloper.Mvc.Extensions.ViewComponents.Helpers.ContadorEstadoPaciente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 98, "\"", 127, 1);
#nullable restore
#line 3 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
WriteAttributeValue("", 106, Model.ClassContainer, 106, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <!-- Start .panel -->\r\n    <div class=\"panel-heading\">\r\n        <h4 class=\"panel-title\">");
#nullable restore
#line 6 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
                           Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div class=\"panel-body pt0\">\r\n        <div class=\"progressbar-stats-1\">\r\n            <div class=\"stats\">\r\n                <i");
            BeginWriteAttribute("class", " class=\"", 383, "\"", 405, 1);
#nullable restore
#line 11 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
WriteAttributeValue("", 391, Model.IconeLg, 391, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                <div id=\"visitor_number\" class=\"stats-number\" data-from=\"0\" data-to=");
#nullable restore
#line 12 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
                                                                               Write(Model.Parcial);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 12 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
                                                                                              Write(Model.Parcial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"progress animated-bar flat transparent progress-bar-xs mb10 mt0\">\r\n                <div class=\"progress-bar progress-bar-white\" role=\"progressbar\" data-transitiongoal=");
#nullable restore
#line 15 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
                                                                                               Write(Model.Progress);

#line default
#line hidden
#nullable disable
            WriteLiteral("></div>\r\n            </div>\r\n            <div class=\"comparison\">\r\n                <p class=\"mb0\"><i");
            BeginWriteAttribute("class", " class=\"", 860, "\"", 882, 1);
#nullable restore
#line 18 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
WriteAttributeValue("", 868, Model.IconeSm, 868, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i> ");
#nullable restore
#line 18 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
                                                         Write(Model.Percentual);

#line default
#line hidden
#nullable disable
            WriteLiteral(" % sobre o total</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cooperchip.ITDeveloper.Mvc.Extensions.ViewComponents.Helpers.ContadorEstadoPaciente> Html { get; private set; }
    }
}
#pragma warning restore 1591
