#pragma checksum "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d040e8f37ecdfdbbd515210e67db849fbdf4346"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funciones_Index), @"mvc.1.0.view", @"/Views/Funciones/Index.cshtml")]
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
#line 1 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\_ViewImports.cshtml"
using ReservaEspectaculo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\_ViewImports.cshtml"
using ReservaEspectaculo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d040e8f37ecdfdbbd515210e67db849fbdf4346", @"/Views/Funciones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"336ea67069a20b2673fe1024086e90c141a9f465", @"/Views/_ViewImports.cshtml")]
    public class Views_Funciones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReservaEspectaculo.Models.Funcion>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/default.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VerReservas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ReservaPelicula", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuardarReserva", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
  
    ViewData["Title"] = "Funciones";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Funciones</h1>\r\n\r\n<p>\r\n");
#nullable restore
#line 11 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
     if (User.IsInRole("Empleado"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d040e8f37ecdfdbbd515210e67db849fbdf43468100", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
     foreach (var item in Model)
    {
        if(item.ButacasDisponibles > 0)
        {       
                       


#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d040e8f37ecdfdbbd515210e67db849fbdf43469990", async() => {
                WriteLiteral("\r\n            <div class=\"column\" style=\"margin-right:10px\">\r\n                <div class=\"card\" style=\"width: 18rem;\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0d040e8f37ecdfdbbd515210e67db849fbdf434610398", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <div class=\"card-body\">\r\n                        <center>\r\n                            <h5 class=\"card-title\"> ");
#nullable restore
#line 30 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Pelicula.Titulo));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                            <p class=\"card-text\">Fecha: ");
#nullable restore
#line 31 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.Fecha));

#line default
#line hidden
#nullable disable
                WriteLiteral(" Hora:  ");
#nullable restore
#line 31 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                                                                                    Write(Html.DisplayFor(modelItem => item.Hora));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n");
#nullable restore
#line 32 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                             if (User.IsInRole("Cliente"))
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <p class=\"card-text\">Butacas disponibles:  ");
#nullable restore
#line 35 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.ButacasDisponibles));

#line default
#line hidden
#nullable disable
                WriteLiteral(" Sala:");
#nullable restore
#line 35 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                                                                                                                  Write(Html.DisplayFor(modelItem => item.Sala.TipoSala.Nombre));

#line default
#line hidden
#nullable disable
                WriteLiteral(" Precio: ");
#nullable restore
#line 35 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                                                                                                                                                                                   Write(Html.DisplayFor(modelItem => item.Sala.TipoSala.Precio));

#line default
#line hidden
#nullable disable
                WriteLiteral("  </p>\r\n                                <label>Butacas:</label>\r\n                                <input type=\"number\" required name=\"cantButacas\" min=\"1\"");
                BeginWriteAttribute("max", " max=\"", 1643, "\"", 1673, 1);
#nullable restore
#line 37 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
WriteAttributeValue("", 1649, item.ButacasDisponibles, 1649, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input name=\"funcionId\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1748, "\"", 1801, 1);
#nullable restore
#line 38 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
WriteAttributeValue("", 1756, Html.DisplayFor(modelItem => item.FuncionId), 1756, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <br />\r\n                                <input type=\"submit\" value=\"Reservar\" class=\"btn btn-primary\" />\r\n");
#nullable restore
#line 41 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                             if (User.IsInRole("Empleado"))
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d040e8f37ecdfdbbd515210e67db849fbdf434616516", async() => {
                    WriteLiteral("<i class=\"fas fa-search\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                                          WriteLiteral(item.FuncionId);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                 if (item.Reservas.Count > 0)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d040e8f37ecdfdbbd515210e67db849fbdf434619213", async() => {
                    WriteLiteral("<i class=\"fas fa-chair\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                                                  WriteLiteral(item.FuncionId);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                 if (item.Reservas.Count == 0)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d040e8f37ecdfdbbd515210e67db849fbdf434622149", async() => {
                    WriteLiteral("<i class=\"fas fa-pen-square\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                                           WriteLiteral(item.FuncionId);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d040e8f37ecdfdbbd515210e67db849fbdf434624522", async() => {
                    WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                                             WriteLiteral(item.FuncionId);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h5 class=\"card-title\">Reservas: ");
#nullable restore
#line 59 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
                                                            Write(Html.DisplayFor(modelItem => item.Reservas.Count));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n");
#nullable restore
#line 60 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"

                                

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </center>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <input type=\"hidden\" name=\"idPelicula\"");
                BeginWriteAttribute("value", " value=\"", 3203, "\"", 3257, 1);
#nullable restore
#line 70 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
WriteAttributeValue("", 3211, Html.DisplayFor(modelItem => item.PeliculaId), 3211, 46, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\Index.cshtml"
            
        }

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.SignInManager<Usuario> _signinmanager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReservaEspectaculo.Models.Funcion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
