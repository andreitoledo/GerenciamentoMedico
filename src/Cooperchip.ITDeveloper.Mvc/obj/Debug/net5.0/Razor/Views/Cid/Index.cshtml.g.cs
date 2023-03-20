#pragma checksum "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Cid\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "599cf56281c73181bb7ad698c0e89bb8366f829f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cid_Index), @"mvc.1.0.view", @"/Views/Cid/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"599cf56281c73181bb7ad698c0e89bb8366f829f", @"/Views/Cid/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66681e992fd8d026c34daa0f70b2fc22366adfff", @"/Views/_ViewImports.cshtml")]
    public class Views_Cid_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cooperchip.ITDeveloper.Domain.Models.Cid>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Cid\Index.cshtml"
   ViewData["Title"] = "Medical Management Sys - Lista de CID"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"" style=""margin-top: 12px;"">

    <div class=""col-lg-12"">
        <p>
            <button class=""btn btn-default create"" data-toggle=""tooltip"" data-placement=""bottom"" title=""Adicionar uma nova CID"" data-original-title=""Adicionar uma nova CID"">  <i class=""glyphicon glyphicon-plus-sign""></i>  </button>
            ");
#nullable restore
#line 11 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Cid\Index.cshtml"
       Write(Html.ActionLink("Home", "Index", "Home", null, new { @class = "btn btn-default" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n\n        <div class=\"animated fadeInRightBig\">\n            <div class=\"panel panel-primary toggle\">\n                <div class=\"panel-heading\">\n                    <h4 class=\"panel-title\"><i class=\"fa fa-magic\"></i> ");
#nullable restore
#line 17 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Cid\Index.cshtml"
                                                                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                </div>

                <div class=""panel-body"">
                    <table class=""table table-striped table-bordered"" style=""width:100%"" cellspacing=""0"" width=""100%"" id=""myTableCid"">
                        <thead>
                            <tr>
                                <th>ID Interno</th>
                                <th>Código</th>
                                <th>Diagnóstico</th>
                                <th class=""text-center"">Ação</th>
                            </tr>
                        </thead>

                        <tbody>
");
#nullable restore
#line 32 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Cid\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\n                                    <td>\n                                        ");
#nullable restore
#line 36 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Cid\Index.cshtml"
                                   Write(item.CidInternalId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </td>\n                                    <td>\n                                        ");
#nullable restore
#line 39 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Cid\Index.cshtml"
                                   Write(item.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </td>\n                                    <td>\n                                        ");
#nullable restore
#line 42 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Cid\Index.cshtml"
                                   Write(item.Diagnostico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    </td>\n                                    <td class=\"text-center\">\n\n                                        <button class=\"btn btn-default details\"\n                                                data-id=\"");
#nullable restore
#line 47 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Cid\Index.cshtml"
                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-toggle=""tooltip"" data-placement=""bottom""
                                                title=""Detalhes da Cid"" data-original-title=""Detalhes da Cid"">
                                            <i class=""glyphicon glyphicon-file""></i>
                                        </button>

                                        <button class=""btn btn-danger delete""
                                                data-id=""");
#nullable restore
#line 53 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Cid\Index.cshtml"
                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-toggle=""tooltip"" data-placement=""bottom""
                                                title=""Excluir CID"" data-original-title=""Excluir CID"">
                                            <i class=""glyphicon glyphicon-trash""></i>
                                        </button>

                                        <button class=""btn btn-primary edit""
                                                data-id=""");
#nullable restore
#line 59 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Cid\Index.cshtml"
                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-toggle=""tooltip"" data-placement=""bottom""
                                                title=""Editar CID"" data-original-title=""Editar CID"">
                                            <i class=""glyphicon glyphicon-edit""></i>
                                        </button>

                                    </td>
                                </tr>
");
#nullable restore
#line 66 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Cid\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>

                        <tfoot>
                            <tr>
                                <th>ID Interno</th>
                                <th>Código</th>
                                <th>Diagnóstico</th>
                                <th class=""text-center"">Ação</th>
                            </tr>
                        </tfoot>

                    </table>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""modal fade modal-style6""
     id=""modalCid""
     tabindex=""-1""
     role=""dialog""
     aria-labelledby=""myModalLabel""
     aria-hidden=""true"">

</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script src=""/bundle/dataTables.min.js""></script>    

    <script type=""text/javascript"">
        $("".details"").click(function () {
            var id = $(this).attr(""data-id"");
            $(""#modalCid"").load(""/Cid/Details?id="" + id, function () {
                $(""#modalCid"").modal();
            });
        });
        $("".delete"").click(function () {
            var id = $(this).attr(""data-id"");
            $(""#modalCid"").load(""/Cid/Delete?id="" + id, function () {
                $(""#modalCid"").modal();
            });
        });
        $("".edit"").click(function () {
            var id = $(this).attr(""data-id"");
            $(""#modalCid"").load(""/Cid/Edit?id="" + id, function () {
                $(""#modalCid"").modal();
            });
        });
        $("".create"").click(function () {
            $(""#modalCid"").load(""/Cid/Create"", function () {
                $(""#modalCid"").modal();
            });
        });
    </script>


    <script>
        $(document).ready(function () {
            $('");
                WriteLiteral("#myTableCid\').DataTable({\n                dom: \'T<\"clear\">lfrtip\',\n                tableTools: {\n                    \"sSwfPath\": \"/myPlugins/copy_csv_xls_pdf.swf\"\n                }\n            });\n        });\n    </script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cooperchip.ITDeveloper.Domain.Models.Cid>> Html { get; private set; }
    }
}
#pragma warning restore 1591
