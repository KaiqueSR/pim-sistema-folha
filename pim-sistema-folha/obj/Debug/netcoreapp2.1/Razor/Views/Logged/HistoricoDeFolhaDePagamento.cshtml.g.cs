#pragma checksum "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5246ebdee8aa0017bbf240e6f56e36c652900d0d11ba05257b863a024df05813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Logged_HistoricoDeFolhaDePagamento), @"mvc.1.0.view", @"/Views/Logged/HistoricoDeFolhaDePagamento.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Logged/HistoricoDeFolhaDePagamento.cshtml", typeof(AspNetCore.Views_Logged_HistoricoDeFolhaDePagamento))]
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
#line 1 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\_ViewImports.cshtml"
using pim_sistema_folha;

#line default
#line hidden
#line 2 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\_ViewImports.cshtml"
using pim_sistema_folha.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"5246ebdee8aa0017bbf240e6f56e36c652900d0d11ba05257b863a024df05813", @"/Views/Logged/HistoricoDeFolhaDePagamento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"422d818384d7407a403869d1ed0e4d698691684c6061c8ffd725c1a8aad84554", @"/Views/_ViewImports.cshtml")]
    public class Views_Logged_HistoricoDeFolhaDePagamento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<pim_sistema_folha.Models.FuncionarioFolhasViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/profile.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GerarFolhaDePagamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HistoricoDeFolhaDePagamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
  
    ViewData["Title"] = "Gerar Folha de Pagamento";

#line default
#line hidden
            BeginContext(120, 130, true);
            WriteLiteral("\r\n\r\n<div class=\"row\" style=\"max-width: 100%\">\r\n    <div class=\"col-md-2 dados\">\r\n        <h4>Dados do funcionário</h4>\r\n\r\n        ");
            EndContext();
            BeginContext(250, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5246ebdee8aa0017bbf240e6f56e36c652900d0d11ba05257b863a024df058136033", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(300, 15, true);
            WriteLiteral("\r\n\r\n        <p>");
            EndContext();
            BeginContext(316, 22, false);
#line 13 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
      Write(Model.Funcionario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(338, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(340, 27, false);
#line 13 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                              Write(Model.Funcionario.Sobrenome);

#line default
#line hidden
            EndContext();
            BeginContext(367, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(385, 46, false);
#line 14 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
      Write(Model.Funcionario.DataNasc.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(431, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(449, 23, false);
#line 15 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
      Write(Model.Funcionario.Cargo);

#line default
#line hidden
            EndContext();
            BeginContext(472, 22, true);
            WriteLiteral("</p>\r\n        <p>CPF: ");
            EndContext();
            BeginContext(495, 21, false);
#line 16 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
           Write(Model.Funcionario.Cpf);

#line default
#line hidden
            EndContext();
            BeginContext(516, 59, true);
            WriteLiteral("</p>\r\n\r\n        <button class=\"btn btn-default btn-logout\">");
            EndContext();
            BeginContext(575, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5246ebdee8aa0017bbf240e6f56e36c652900d0d11ba05257b863a024df058139344", async() => {
                BeginContext(598, 4, true);
                WriteLiteral("Sair");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(606, 132, true);
            WriteLiteral("</button>\r\n    </div>\r\n    <div class=\"col-md-3 central\">\r\n        <h4>Central de ações</h4>\r\n\r\n        <button class=\"btn-central\">");
            EndContext();
            BeginContext(738, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5246ebdee8aa0017bbf240e6f56e36c652900d0d11ba05257b863a024df0581310879", async() => {
                BeginContext(776, 24, true);
                WriteLiteral("Gerar Folha de Pagamento");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(804, 62, true);
            WriteLiteral("<br /></button>\r\n        <button class=\"btn-central-selected\">");
            EndContext();
            BeginContext(866, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5246ebdee8aa0017bbf240e6f56e36c652900d0d11ba05257b863a024df0581312355", async() => {
                BeginContext(910, 31, true);
                WriteLiteral("Histórico de Folha de Pagamento");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(945, 218, true);
            WriteLiteral("</button>\r\n    </div>\r\n    <div class=\"col-md-6 content\">\r\n        <h3>Histórico de Folha de Pagamento</h3>\r\n        \r\n        <div class=\"filtros row\">\r\n            <div class=\"col-md-5 text-center\">\r\n                ");
            EndContext();
            BeginContext(1163, 340, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5246ebdee8aa0017bbf240e6f56e36c652900d0d11ba05257b863a024df0581314013", async() => {
                BeginContext(1169, 327, true);
                WriteLiteral(@"
                    <p style=""font-weight: bold"">Período específico:</p>
                    <span class=""span-input-data"">De:</span><input type=""date"" class=""input-data"" /><br />
                    <span class=""span-input-data"" style=""margin-left: 10px"">À:</span><input type=""date"" class=""input-data"" />
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1503, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-7\">\r\n                ");
            EndContext();
            BeginContext(1579, 178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5246ebdee8aa0017bbf240e6f56e36c652900d0d11ba05257b863a024df0581315912", async() => {
                BeginContext(1585, 165, true);
                WriteLiteral("\r\n                    <input id=\"PesquisarId\" runat=\"server\" placeholder=\"Pesquisar ID da Folha\" type=\"number\" class=\"form-control pesquisar-id\" />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1757, 119, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row baixo\">\r\n            <div class=\"historico col-md-6\">\r\n");
            EndContext();
#line 47 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                 foreach (var item in Model.FolhasPagamento)
                {
                    

#line default
#line hidden
#line 49 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                     if (item.Id == Model.FolhaPagamentoSelected.Id)
                    {

#line default
#line hidden
            BeginContext(2050, 69, true);
            WriteLiteral("                        <button class=\"btn-folha btn-folha-selected\">");
            EndContext();
            BeginContext(2119, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5246ebdee8aa0017bbf240e6f56e36c652900d0d11ba05257b863a024df0581318381", async() => {
                BeginContext(2146, 21, true);
                WriteLiteral("Folha de pagamento - ");
                EndContext();
                BeginContext(2168, 36, false);
#line 51 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                                                                                                                Write(item.DataEmissao.ToShortDateString());

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
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
            BeginContext(2208, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 52 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2291, 50, true);
            WriteLiteral("                        <button class=\"btn-folha\">");
            EndContext();
            BeginContext(2341, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5246ebdee8aa0017bbf240e6f56e36c652900d0d11ba05257b863a024df0581321409", async() => {
                BeginContext(2368, 21, true);
                WriteLiteral("Folha de pagamento - ");
                EndContext();
                BeginContext(2390, 36, false);
#line 55 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                                                                                             Write(item.DataEmissao.ToShortDateString());

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
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
            BeginContext(2430, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 56 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                    }

#line default
#line hidden
#line 56 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(2483, 187, true);
            WriteLiteral("            </div>\r\n\r\n            <div class=\"view-folha col-md-6\">\r\n                <div class=\"topo-folha\">\r\n                    <h4>Empresa X - Holerite</h4>\r\n\r\n                    <p>");
            EndContext();
            BeginContext(2671, 22, false);
#line 64 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                  Write(Model.Funcionario.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2693, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2695, 27, false);
#line 64 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                                          Write(Model.Funcionario.Sobrenome);

#line default
#line hidden
            EndContext();
            BeginContext(2722, 29, true);
            WriteLiteral("</p>\r\n                    <p>");
            EndContext();
            BeginContext(2752, 21, false);
#line 65 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                  Write(Model.Funcionario.Cpf);

#line default
#line hidden
            EndContext();
            BeginContext(2773, 29, true);
            WriteLiteral("</p>\r\n                    <p>");
            EndContext();
            BeginContext(2803, 23, false);
#line 66 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                  Write(Model.Funcionario.Cargo);

#line default
#line hidden
            EndContext();
            BeginContext(2826, 458, true);
            WriteLiteral(@"</p>
                </div>

                <table class=""text-center corpo-folha"">
                    <thead>
                        <tr>
                            <th class=""text-center"" style=""width: 150px"">Descrição</th>
                            <th class=""text-center"">Extra</th>
                            <th class=""text-center"">Desconto</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 78 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                         foreach (var item in Model.FolhaPagamentoSelected.ExtrasDescontos)
                        {

#line default
#line hidden
            BeginContext(3404, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(3475, 14, false);
#line 81 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                               Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(3489, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 82 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                                 if (item.Valor >= 0)
                                {

#line default
#line hidden
            BeginContext(3586, 61, true);
            WriteLiteral("                                    <td class=\"text-info\">R$ ");
            EndContext();
            BeginContext(3648, 10, false);
#line 84 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                                                        Write(item.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(3658, 54, true);
            WriteLiteral("</td>\r\n                                    <td></td>\r\n");
            EndContext();
#line 86 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3820, 110, true);
            WriteLiteral("                                    <td></td>\r\n                                    <td class=\"text-danger\">R$ ");
            EndContext();
            BeginContext(3931, 20, false);
#line 90 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                                                          Write(Math.Abs(item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(3951, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 91 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                                }

#line default
#line hidden
            BeginContext(3993, 35, true);
            WriteLiteral("                            </tr>\r\n");
            EndContext();
#line 93 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                        }

#line default
#line hidden
            BeginContext(4055, 223, true);
            WriteLiteral("                    </tbody>\r\n\r\n                    <tfoot>\r\n                        <tr>\r\n                            <td rowspan=\"2\" style=\"text-align: left\">Mensagem: </td>\r\n                            <td>Total Extras: ");
            EndContext();
            BeginContext(4279, 39, false);
#line 99 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                                         Write(Model.FolhaPagamentoSelected.TotalExtra);

#line default
#line hidden
            EndContext();
            BeginContext(4318, 56, true);
            WriteLiteral("</td>\r\n                            <td>Total Descontos: ");
            EndContext();
            BeginContext(4375, 52, false);
#line 100 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                                            Write(Math.Abs(Model.FolhaPagamentoSelected.TotalDesconto));

#line default
#line hidden
            EndContext();
            BeginContext(4427, 156, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td>Liq. A Receber</td>\r\n                            <td>R$ ");
            EndContext();
            BeginContext(4584, 41, false);
#line 104 "C:\Users\kaique.ramos\Documents\pim-sistema-folha\pim-sistema-folha\Views\Logged\HistoricoDeFolhaDePagamento.cshtml"
                              Write(Model.FolhaPagamentoSelected.TotalLiquido);

#line default
#line hidden
            EndContext();
            BeginContext(4625, 148, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n                    </tfoot>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<pim_sistema_folha.Models.FuncionarioFolhasViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591