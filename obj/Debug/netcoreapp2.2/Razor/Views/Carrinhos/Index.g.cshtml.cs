#pragma checksum "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96008f5d407614d91132f88754720d89b784244c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinhos_Index), @"mvc.1.0.view", @"/Views/Carrinhos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carrinhos/Index.cshtml", typeof(AspNetCore.Views_Carrinhos_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96008f5d407614d91132f88754720d89b784244c", @"/Views/Carrinhos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f845085478c17c21ccf585a30cbb75e9ac1be715", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinhos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASPCoreSample.Models.Carrinhos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 56, true);
            WriteLiteral("\n</br></br>\n<h1>Carrinho de Compras</h1>\n</br></br>\n\n<p>");
            EndContext();
            BeginContext(147, 10, false);
#line 11 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
Write(ViewBag.Id);

#line default
#line hidden
            EndContext();
            BeginContext(157, 107, true);
            WriteLiteral(" 1</p>\n\n<table class=\"table table-bordered\">\n    <thead>\n        <tr>\n            <!--<th>\n                ");
            EndContext();
            BeginContext(265, 38, false);
#line 17 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(303, 59, true);
            WriteLiteral("\n            </th>-->\n            <!--<th>\n                ");
            EndContext();
            BeginContext(363, 45, false);
#line 20 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Idproduto));

#line default
#line hidden
            EndContext();
            BeginContext(408, 72, true);
            WriteLiteral("\n            </th>-->\n            \n            <!--<th>\n                ");
            EndContext();
            BeginContext(481, 45, false);
#line 24 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Idcliente));

#line default
#line hidden
            EndContext();
            BeginContext(526, 56, true);
            WriteLiteral("\n            </th>-->\n             <th>\n                ");
            EndContext();
            BeginContext(583, 40, false);
#line 27 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(623, 65, true);
            WriteLiteral("\n            </th>\n            \n            <th>\n                ");
            EndContext();
            BeginContext(689, 46, false);
#line 31 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(735, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(788, 41, false);
#line 34 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(829, 73, true);
            WriteLiteral("\n            </th>             \n        </tr>\n    </thead>\n\n\n    <tbody>\n");
            EndContext();
#line 41 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(933, 53, true);
            WriteLiteral("        <tr>\n            <!--<td>-->\n                ");
            EndContext();
            BeginContext(987, 36, false);
#line 44 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
           Write(Html.HiddenFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 67, true);
            WriteLiteral("\n            <!--</td>-->\n\n            <!--<td>-->\n                ");
            EndContext();
            BeginContext(1091, 43, false);
#line 48 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
           Write(Html.HiddenFor(modelItem => item.Idproduto));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 79, true);
            WriteLiteral("\n            <!--</td>-->\n            \n            <!--<td>-->\n                ");
            EndContext();
            BeginContext(1214, 43, false);
#line 52 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
           Write(Html.HiddenFor(modelItem => item.Idcliente));

#line default
#line hidden
            EndContext();
            BeginContext(1257, 60, true);
            WriteLiteral("\n            <!--</td>-->\n\n            <td>\n                ");
            EndContext();
            BeginContext(1318, 39, false);
#line 56 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 126, true);
            WriteLiteral("\n            </td>\n            \n             <td>                \n                <!--<input type=\"number\" name=\"fname\" value=");
            EndContext();
            BeginContext(1484, 45, false);
#line 60 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1529, 21, true);
            WriteLiteral(">-->\n                ");
            EndContext();
            BeginContext(1551, 45, false);
#line 61 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 53, true);
            WriteLiteral("\n            </td>\n             <td>\n                ");
            EndContext();
            BeginContext(1650, 40, false);
#line 64 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(1690, 381, true);
            WriteLiteral(@"
            </td>
            <!--<td>
                <select asp-for=""Idformapag"" class =""form-control"" asp-items=""ViewBag.Idformapag""></select>
            </td>
             <td>
                <select asp-for=""Idstatus"" class =""form-control"" asp-items=""ViewBag.Idstatus""></select>
            </td>-->
            <td>
                <!--<a asp-action=""Edit"" asp-route-id=""");
            EndContext();
            BeginContext(2072, 7, false);
#line 73 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
                                                  Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2079, 120, true);
            WriteLiteral("\">  <span class=\"glyphicon glyphicon-pencil\"></span></a> |-->\n                <!--<a asp-action=\"Details\" asp-route-id=\"");
            EndContext();
            BeginContext(2200, 7, false);
#line 74 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
                                                     Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2207, 35, true);
            WriteLiteral("\">Details</a> |-->\n                ");
            EndContext();
            BeginContext(2242, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96008f5d407614d91132f88754720d89b784244c11166", async() => {
                BeginContext(2289, 47, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-trash\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2340, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 78 "/home/vitor/Projetos/CrudPostgreQLDapperAspNetCore/Views/Carrinhos/Index.cshtml"
}

#line default
#line hidden
            BeginContext(2375, 653, true);
            WriteLiteral(@"    </tbody>
</table>

 

<button type=""button"" class=""btn btn-primary"">Comprar</button>

<!--<script>
var table = document.getElementsByTagName(""table"")[0];
var tbody = table.getElementsByTagName(""tbody"")[0];
tbody.onclick = function (e) {
    e = e || window.event;
    var data = [];
    var target = e.srcElement || e.target;
    while (target && target.nodeName !== ""TR"") {
        target = target.parentNode;
    }
    if (target) {
        var cells = target.getElementsByTagName(""td"");
        for (var i = 0; i < cells.length; i++) {
            data.push(cells[i].innerHTML);
        }
    }
    alert(data[0] + '' + data[4]);
};
</script>-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASPCoreSample.Models.Carrinhos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
