#pragma checksum "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "571e15928c355cbd4b156c5485a7c504f9a6b567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_MostrarDatos), @"mvc.1.0.view", @"/Views/Usuarios/MostrarDatos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"571e15928c355cbd4b156c5485a7c504f9a6b567", @"/Views/Usuarios/MostrarDatos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"336ea67069a20b2673fe1024086e90c141a9f465", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_MostrarDatos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReservaEspectaculo.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActualizarTelefono", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Direcciones", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
  
    ViewData["Title"] = "Mis datos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Mis Datos</h4>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayNameFor(model => model.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayFor(model => model.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "571e15928c355cbd4b156c5485a7c504f9a6b5677686", async() => {
                WriteLiteral(" <i class=\"fas fa-pen-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
                                                                                                                     WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaAlta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayFor(model => model.FechaAlta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n    <h4>Dirección ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "571e15928c355cbd4b156c5485a7c504f9a6b56711706", async() => {
                WriteLiteral(" <i class=\"fas fa-pen-square\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
                                                                      WriteLiteral(Model.Direccion.DireccionId);

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
            WriteLiteral(" </h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion.Calle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayFor(model => model.Direccion.Calle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion.Altura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayFor(model => model.Direccion.Altura));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion.Localidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayFor(model => model.Direccion.Localidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Usuarios\MostrarDatos.cshtml"
       Write(Html.DisplayFor(model => model.Direccion.Provincia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReservaEspectaculo.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591