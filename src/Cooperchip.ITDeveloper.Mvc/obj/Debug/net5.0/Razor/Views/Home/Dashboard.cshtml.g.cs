#pragma checksum "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d70c5dc2d85065c1181d8ff7796892554a505119"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d70c5dc2d85065c1181d8ff7796892554a505119", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66681e992fd8d026c34daa0f70b2fc22366adfff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PartialViews/_estado_paciente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bundle/dashboard.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\andre\source\repos\medico\Curso Asp.Net Core 2.2 - DoZero\ITDeveloper\src\Cooperchip.ITDeveloper.Mvc\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<vc:cabecalho-modulo titulo=\"Dashbord\" subtitulo=\"Estatísticas e Marcadores do Sistema\">\r\n</vc:cabecalho-modulo>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d70c5dc2d85065c1181d8ff7796892554a5051194783", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"



<div class=""panel panel-default panel-controls"">
    <div class=""panel panel-heading"">
        <h3>Estatísticas e Marcadores em Tempo Real</h3>
    </div>

    <div class=""panel panel-body"">
        <!-- Start .row -->
        <div class=""col-lg-8 col-md-12 col-sm-12 col-xs-12"">
            <!-- col-lg-8 start here -->
            <div class=""col-lg-9 col-sm-9 col-xs-12 p0"">
                <!-- col-lg-9 start here -->
                <div class=""panel panel-default plain btrr0 bbrr0 panelRefresh"" data-mh=""payments"">
                    <!-- Start .panel -->
                    <div class=""panel-heading"">
                        <h4 class=""panel-title""><i class=""fa fa-dollar""></i> Payment received</h4>
                    </div>
                    <div class=""panel-body"">
                        <div id=""line-chart-payments"" style=""width: 100%; height:250px;""></div>
                    </div>
                </div>
                <!-- End .panel -->
            </div>
         ");
            WriteLiteral(@"   <!-- col-lg-9 end here -->
            <div class=""col-lg-3 col-sm-3 col-xs-12 p0"">
                <!-- col-lg-3 start here -->
                <div class=""panel panel-default tile btlr0 bblr0"" data-mh=""payments"">
                    <!-- Start .panel -->
                    <div class=""panel-body"">
                        <div class=""spark clearfix"">
                            <div class=""spark-info mb0"">
                                <span class=""number stats-number money s32"" data-from=""0"" data-to=""12857"">0</span>
                            </div>
                            <div class=""spark-info mtm5"">Total income</div>
                        </div>
                        <div class=""spark clearfix"">
                            <div class=""spark-info mb0"">
                                <span class=""number stats-number money s32 color-gray-light"" data-from=""0"" data-to=""4578""></span>
                            </div>
                            <div class=""sparkline spark-payme");
            WriteLiteral(@"nts mt0""></div>
                            <div class=""spark-info"">Credit Card</div>
                        </div>
                        <div class=""spark clearfix"">
                            <div class=""spark-info mb0"">
                                <span class=""number stats-number money s32 color-gray-light"" data-from=""0"" data-to=""5241""></span>
                            </div>
                            <div class=""sparkline spark-payments mt0""></div>
                            <div class=""spark-info"">Pay Pal</div>
                        </div>
                        <div class=""db per100"">
                            <a href=""#"" class=""btn btn-info ml20 mt5"">Details</a>
                        </div>
                    </div>
                </div>
                <!-- End .panel -->
            </div>
            <!-- col-lg-3 end here -->
        </div>
        <!-- col-lg-8 end here -->
        <div class=""col-lg-4 col-md-12 col-sm-12 col-xs-12"">
            <!-- col-");
            WriteLiteral(@"lg-4 start here -->
            <div class=""panel panel-default plain"">
                <!-- Start .panel -->
                <div class=""panel-heading"">
                    <h4 class=""panel-title""><i class=""glyphicon glyphicon-user""></i> Customer experience</h4>
                </div>
                <div class=""panel-body"">
                    <div class=""text-center"">
                        <div id=""customer-exp"" class=""custom-progressbar blue"" style=""width:244px;height:244px;"">
                            <div class=""percent"">
                                80<span>%</span>
                            </div>
                            <div class=""description"">satisfaction</div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- End .panel -->
        </div>
        <!-- col-lg-4 end here -->
    </div>
    <!-- End .row -->
    <div class=""row"">
        <!-- Start .row -->
        <div class=""col-lg-8 col-md-12"">");
            WriteLiteral(@"
            <!-- col-lg-8 start here -->
            <div class=""row"">
                <!-- Start .row -->
                <div class=""col-lg-6 col-md-6 col-sm-12"">
                    <!-- col-lg-6 start here -->
                    <div class=""col-lg-6 col-sm-6 p0"">
                        <!-- col-lg-6 start here -->
                        <div class=""panel tile panelRefresh"">
                            <!-- Start .panel -->
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""></h4>
                            </div>
                            <div class=""panel-body p0"">
                                <div class=""weather snow"">
                                    <div class=""degree color-red"">-5&deg;</div>
                                    <div class=""location pb15""><i class=""l-basic-geolocalize-01""></i> Varna</div>
                                    <div class=""icon"">
                                        <canvas id=""wea");
            WriteLiteral(@"ther-now"" width=""96"" height=""96""></canvas>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- End .panel -->
                    </div>
                    <!-- col-lg-6 end here -->
                    <div class=""col-lg-6 col-sm-6 p0"">
                        <!-- col-lg-6 start here -->
                        <div class=""panel tile btlr0 bblr0 mb0"">
                            <!-- Start .panel -->
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""></h4>
                            </div>
                            <div class=""panel-body p0"">
                                <div class=""row weather no-padding"">
                                    <!-- Start .row -->
                                    <div class=""col-md-5 col-sm-5 text-center red-bg"">
                                        <canvas clas");
            WriteLiteral(@"s=""mt15"" id=""weather-monday"" width=""64"" height=""64""></canvas>
                                        <h5 class=""uppercase strong color-white"">Monday</h5>
                                    </div>
                                    <div class=""col-md-7 col-sm-7 text-center"">
                                        <div class=""degree color-red"">-2&deg;</div>
                                        <p class=""text-muted uppercase s12"">forecast</p>
                                    </div>
                                </div>
                                <!-- End .row -->
                            </div>
                        </div>
                        <!-- End .panel -->
                        <div class=""panel tile btlr0 bblr0 mb0"">
                            <!-- Start .panel -->
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""></h4>
                            </div>
                            <div class=""panel-");
            WriteLiteral(@"body p0"">
                                <div class=""row weather no-padding"">
                                    <!-- Start .row -->
                                    <div class=""col-md-5 col-sm-5 text-center blue-bg"">
                                        <canvas class=""mt15"" id=""weather-tuesday"" width=""64"" height=""64""></canvas>
                                        <h5 class=""uppercase strong color-white"">Tuesday</h5>
                                    </div>
                                    <div class=""col-md-7 col-sm-7 text-center"">
                                        <div class=""degree color-blue"">0&deg;</div>
                                        <p class=""text-muted uppercase s12"">forecast</p>
                                    </div>
                                </div>
                                <!-- End .row -->
                            </div>
                        </div>
                        <!-- End .panel -->
                    </div>
          ");
            WriteLiteral(@"          <!-- col-lg-6 end here -->
                </div>
                <!-- col-lg-6 end here -->
                <div class=""col-lg-6 col-md-6 col-sm-12"">
                    <!-- col-lg-6 start here -->
                    <div class=""panel panel-default plain toggle panelClose panelRefresh"">
                        <!-- Start .panel -->
                        <div class=""panel-heading"">
                            <h4 class=""panel-title""><i class=""l-basic-target""></i> Montly Sales Goals</h4>
                        </div>
                        <div class=""panel-body"">
                            <div class=""row"">
                                <!-- Start .row -->
                                <div class=""col-md-6"">
                                    <ul class=""list-unstyled"" style=""margin-bottom:13px;"">
                                        <li class=""mb15"">
                                            <p class=""strong mb0"">
                                                Shir");
            WriteLiteral(@"ts <span class=""text-muted pull-right small"">100 of 200 sold</span>
                                            </p>
                                            <div class=""progress animated-bar progress-bar-sm flat mt0"">
                                                <div class=""progress-bar progress-bar-primary"" role=""progressbar"" data-transitiongoal=""50""></div>
                                            </div>
                                        </li>
                                        <li class=""mb15"">
                                            <p class=""strong mb0"">
                                                Shoes <span class=""text-muted pull-right small"">150 of 200 sold</span>
                                            </p>
                                            <div class=""progress animated-bar progress-bar-sm flat mt0"">
                                                <div class=""progress-bar progress-bar-danger"" role=""progressbar"" data-transitiongoal=""75""></div>
    ");
            WriteLiteral(@"                                        </div>
                                        </li>
                                        <li class=""mb15"">
                                            <p class=""strong mb0"">
                                                Watches <span class=""text-muted pull-right small"">25 of 200 sold</span>
                                            </p>
                                            <div class=""progress animated-bar progress-bar-sm flat mt0"">
                                                <div class=""progress-bar progress-bar-warning"" role=""progressbar"" data-transitiongoal=""12""></div>
                                            </div>
                                        </li>
                                        <li>
                                            <p class=""strong mb0"">
                                                Coats <span class=""text-muted pull-right small"">195 of 300 sold</span>
                                            <");
            WriteLiteral(@"/p>
                                            <div class=""progress animated-bar progress-bar-sm flat mt0"">
                                                <div class=""progress-bar progress-bar-success"" role=""progressbar"" data-transitiongoal=""66""></div>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                                <div class=""col-md-6"">
                                    <div class=""text-center"">
                                        <div id=""sales-goal"" class=""custom-progressbar green pull-left mr15"" style=""width:150px;height:150px;"">
                                            <div class=""percent"">470</div>
                                            <div class=""description s14"">of 900 sold</div>
                                        </div>
                                    </div>
                                    <div class=""custom-progr");
            WriteLiteral(@"essbar-legend text-center"">
                                        <p class=""text-left""><span class=""strong"">65%</span> Sold</p>
                                        <p class=""text-left""><span class=""strong"">35% </span> Left</p>
                                    </div>
                                </div>
                            </div>
                            <!-- End .row -->
                        </div>
                    </div>
                    <!-- End .panel -->
                </div>
                <!-- col-lg-6 end here -->
            </div>
            <!-- End .row -->
            <div class=""row"">
                <!-- Start .row -->
                <div class=""col-lg-12"">
                    <!-- col-lg-12 start here -->
                    <div class=""col-lg-4 col-md-6 p0"">
                        <!-- col-lg-4 start here -->
                        <div class=""panel panel-default tile btrr0 bbrr0"" data-mh=""sales-locations"">
                            <");
            WriteLiteral(@"!-- Start .panel -->
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><i class=""glyphicon glyphicon-list-alt""></i> Latest Sales</h4>
                            </div>
                            <div class=""panel-body pt0"">
                                <ul class=""list-unstyled mb0"">
                                    <li class=""mb5 pb5 bbdashed"">
                                        <span class=""strong"">New Your:</span> order
                                        <span class=""color-red"">#345675</span> - 176$
                                    </li>
                                    <li class=""mb5 pb5 bbdashed"">
                                        <span class=""strong"">Vancuver:</span> order
                                        <span class=""color-red"">#345674</span> - 56$
                                    </li>
                                    <li class=""mb5 pb5 bbdashed"">
                                     ");
            WriteLiteral(@"   <span class=""strong"">London:</span> order
                                        <span class=""color-red"">#345673</span> - 12$
                                    </li>
                                    <li class=""mb5 pb5 bbdashed"">
                                        <span class=""strong"">Barcelona:</span> order
                                        <span class=""color-red"">#345672</span> - 34$
                                    </li>
                                    <li class=""mb5 pb5 bbdashed"">
                                        <span class=""strong"">Moskva:</span> order
                                        <span class=""color-red"">#345671</span> - 15$
                                    </li>
                                    <li class=""mb5 pb5"">
                                        <span class=""strong"">Tokio:</span> order
                                        <span class=""color-red"">#345669</span> - 67$
                                    </li>
                   ");
            WriteLiteral(@"             </ul>
                            </div>
                        </div>
                        <!-- End .panel -->
                    </div>
                    <!-- col-lg-4 end here -->
                    <div class=""col-lg-8 col-md-6 p0"">
                        <!-- col-lg-8 start here -->
                        <div class=""panel panel-default plain panelRefresh btlr0 bblr0"" data-mh=""sales-locations"">
                            <!-- Start .panel -->
                            <div class=""panel-heading"">
                                <h4 class=""panel-title""><i class=""fa l-basic-geolocalize-01""></i> Last sales locations</h4>
                            </div>
                            <div class=""panel-body p0"">
                                <div id=""world-map"" style=""width: 100%; height: 250px""></div>
                            </div>
                        </div>
                        <!-- End .panel -->
                    </div>
                    <!-- co");
            WriteLiteral(@"l-lg-8 end here -->
                </div>
                <!-- col-lg-12 end here -->
            </div>
            <!-- End .row -->
        </div>
        <!-- col-lg-8 end here -->
        <div class=""col-lg-4 col-md-12"">
            <!-- col-lg-4 start here -->
            <div class=""panel panel-default plain toggle panelMove panelClose panelRefresh"">
                <!-- Start .panel -->
                <div class=""panel-heading"">
                    <h4 class=""panel-title""><i class=""fa fa-comments""></i>Customer Comments</h4>
                </div>
                <div class=""panel-body"">
                    <ul class=""list-group recent-comments"">
                        <li class=""list-group-item clearfix comment-success"">
                            <div class=""avatar pull-left mr15"">
                                <img src=""/img/avatars/2.jpg"" alt=""avatar"">
                            </div>
                            <p class=""text-ellipsis""><span class=""name strong"">Ben Simp");
            WriteLiteral(@"son: </span> Very happy with your support is really great, keep that quality.</p>
                            <span class=""date text-muted small pull-left"">Dec 18, 2014, 4:24 pm</span>
                            <a href=""#"" class=""see-more small pull-right"">View comment</a>
                        </li>
                        <li class=""list-group-item clearfix comment-default"">
                            <div class=""avatar pull-left mr15"">
                                <img src=""/img/avatars/3.jpg"" alt=""avatar"">
                            </div>
                            <p class=""text-ellipsis""><span class=""name strong"">Jonh: </span> Fine items but you could invest more time.</p>
                            <span class=""date text-muted small pull-left"">Dec 18, 2014, 12:11 pm</span>
                            <a href=""#"" class=""see-more small pull-right"">View comment</a>
                        </li>
                        <li class=""list-group-item clearfix comment-info"">
            ");
            WriteLiteral(@"                <div class=""avatar pull-left mr15"">
                                <img src=""/img/avatars/4.jpg"" alt=""avatar"">
                            </div>
                            <p class=""text-ellipsis""><span class=""name strong"">Dina Dowsen: </span> Awesome items, really fast delivery.</p>
                            <span class=""date text-muted small pull-left"">Dec 18, 2014, 8:17 pm</span>
                            <a href=""#"" class=""see-more small pull-right"">View comment</a>
                        </li>
                        <li class=""list-group-item clearfix comment-warning"">
                            <div class=""avatar pull-left mr15"">
                                <img src=""/img/avatars/5.jpg"" alt=""avatar"">
                            </div>
                            <p class=""text-ellipsis""><span class=""name strong"">Matt: </span> I`m not impressed but is fine.</p>
                            <span class=""date text-muted small pull-left"">Dec 17, 2014, 6:24 pm</span>");
            WriteLiteral(@"
                            <a href=""#"" class=""see-more small pull-right"">View comment</a>
                        </li>
                        <li class=""list-group-item clearfix comment-danger"">
                            <div class=""avatar pull-left mr15"">
                                <img src=""/img/avatars/6.jpg"" alt=""avatar"">
                            </div>
                            <p class=""text-ellipsis""><span class=""name strong"">Ben Simpson: </span> This is worst item i ever seen.</p>
                            <span class=""date text-muted small pull-left"">Dec 16, 2014, 1:20 pm</span>
                            <a href=""#"" class=""see-more small pull-right"">View comment</a>
                        </li>
                    </ul>
                </div>
            </div>
            <!-- End .panel -->
        </div>
        <!-- col-lg-4 end here -->
    </div>
    <!-- End .row -->

</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d70c5dc2d85065c1181d8ff7796892554a50511927483", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
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
