#pragma checksum "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5862839ac3f4565883a9b7c99babcd473d81c96c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Funciones_VerReservas), @"mvc.1.0.view", @"/Views/Funciones/VerReservas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5862839ac3f4565883a9b7c99babcd473d81c96c", @"/Views/Funciones/VerReservas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"336ea67069a20b2673fe1024086e90c141a9f465", @"/Views/_ViewImports.cshtml")]
    public class Views_Funciones_VerReservas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReservaEspectaculo.Models.Reserva>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
  
    ViewData["Title"] = "Ver Reservas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Reservas pasadas</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaAlta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayNameFor(model => model.ClienteId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayNameFor(model => model.Funcion.Pelicula.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>           \r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayNameFor(model => model.CantidadButacas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayNameFor(model => model.Funcion.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>      \r\n        \r\n");
#nullable restore
#line 31 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
         foreach (var item in Model)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
             if (item.Funcion.Fecha < DateTime.Today)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaAlta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cliente.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Funcion.Pelicula.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>          \r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayFor(modelItem => item.CantidadButacas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Funcion.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n    </tbody>\r\n</table>\r\n\r\n<h3>Reservas futuras</h3>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaAlta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 69 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayNameFor(model => model.ClienteId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 72 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayNameFor(model => model.Funcion.Pelicula.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 75 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayNameFor(model => model.CantidadButacas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 78 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayNameFor(model => model.Funcion.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 85 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
         foreach (var item in Model)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
             if (item.Funcion.Fecha >= DateTime.Today)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaAlta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cliente.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Funcion.Pelicula.Titulo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayFor(modelItem => item.CantidadButacas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
           Write(Html.DisplayFor(modelItem => item.Funcion.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 110 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "C:\Users\Nora\Desktop\Facultad\NUEVAS TECNOLOGIAS\Proyecto Res_Esp\ReservaEspectaculo\Views\Funciones\VerReservas.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReservaEspectaculo.Models.Reserva>> Html { get; private set; }
    }
}
#pragma warning restore 1591
