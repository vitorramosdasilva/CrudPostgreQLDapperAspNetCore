#pragma checksum "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Itenspedidos/Carrinho.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cafba2b83ddc310fe6b075676eaf732eed0f838"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Itenspedidos_Carrinho), @"mvc.1.0.view", @"/Views/Itenspedidos/Carrinho.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Itenspedidos/Carrinho.cshtml", typeof(AspNetCore.Views_Itenspedidos_Carrinho))]
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
#line 1 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/_ViewImports.cshtml"
using ASPCoreSample;

#line default
#line hidden
#line 2 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/_ViewImports.cshtml"
using ASPCoreSample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cafba2b83ddc310fe6b075676eaf732eed0f838", @"/Views/Itenspedidos/Carrinho.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f845085478c17c21ccf585a30cbb75e9ac1be715", @"/Views/_ViewImports.cshtml")]
    public class Views_Itenspedidos_Carrinho : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPCoreSample.Models.Itenspedidos>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 4478, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-xs-8"">
            <div class=""panel panel-info"">
                <div class=""panel-heading"">
                    <div class=""panel-title"">
                        <div class=""row"">
                            <div class=""col-xs-6"">
                                <h5><span class=""glyphicon glyphicon-shopping-cart""></span> Shopping Cart</h5>
                            </div>
                            <div class=""col-xs-6"">
                                <button type=""button"" class=""btn btn-primary btn-sm btn-block"">
                                    <span class=""glyphicon glyphicon-share-alt""></span> Continue shopping
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""panel-body"">
                    <div class=""row"">
                        <div class=""col-xs-2""><img class=""img-responsive"" src=""http:");
            WriteLiteral(@"//placehold.it/100x70"">
                        </div>
                        <div class=""col-xs-4"">
                            <h4 class=""product-name""><strong>ViewBag.IdProduto</strong></h4><h4><small>ViewBag.Descricao</small></h4>
                        </div>
                        <div class=""col-xs-6"">
                            <div class=""col-xs-6 text-right"">
                                <h6><strong>25.00 <span class=""text-muted"">x</span></strong></h6>
                            </div>
                            <div class=""col-xs-4"">
                                <input type=""text"" class=""form-control input-sm"" value=""1"">
                            </div>
                            <div class=""col-xs-2"">
                                <button type=""button"" class=""btn btn-link btn-xs"">
                                    <span class=""glyphicon glyphicon-trash""> </span>
                                </button>
                            </div>
                        </div>
          ");
            WriteLiteral(@"          </div>
                    <hr>
                    <div class=""row"">
                        <div class=""col-xs-2""><img class=""img-responsive"" src=""http://placehold.it/100x70"">
                        </div>
                        <div class=""col-xs-4"">
                            <h4 class=""product-name""><strong>ViewBag.IdProduto</strong></h4><h4><small>ViewBag.Descricao</small></h4>
                        </div>
                        <div class=""col-xs-6"">
                            <div class=""col-xs-6 text-right"">
                                <h6><strong>25.00 <span class=""text-muted"">x</span></strong></h6>
                            </div>
                            <div class=""col-xs-4"">
                                <input type=""text"" class=""form-control input-sm"" value=""1"">
                            </div>
                            <div class=""col-xs-2"">
                                <button type=""button"" class=""btn btn-link btn-xs"">
                                    <sp");
            WriteLiteral(@"an class=""glyphicon glyphicon-trash""> </span>
                                </button>
                            </div>
                        </div>
                    </div>
                    <hr>
                    <div class=""row"">
                        <div class=""text-center"">
                            <div class=""col-xs-9"">
                                <h6 class=""text-right"">Added items?</h6>
                            </div>
                            <div class=""col-xs-3"">
                                <button type=""button"" class=""btn btn-default btn-sm btn-block"">
                                    Update cart
                                </button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""panel-footer"">
                    <div class=""row text-center"">
                        <div class=""col-xs-9"">
                            <h4 class=""text-right"">Total <strong>$50.00</stron");
            WriteLiteral(@"g></h4>
                        </div>
                        <div class=""col-xs-3"">
                            <button type=""button"" class=""btn btn-success btn-block"">
                                Checkout
                            </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPCoreSample.Models.Itenspedidos> Html { get; private set; }
    }
}
#pragma warning restore 1591
