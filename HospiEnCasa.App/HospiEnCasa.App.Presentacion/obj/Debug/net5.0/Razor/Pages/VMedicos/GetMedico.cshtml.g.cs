#pragma checksum "C:\ProyectosCiclo3G10\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41004a8f01e4046511c5d947c49a2c4f7981ba09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.App.Presentacion.Pages.VMedicos.Pages_VMedicos_GetMedico), @"mvc.1.0.razor-page", @"/Pages/VMedicos/GetMedico.cshtml")]
namespace HospiEnCasa.App.Presentacion.Pages.VMedicos
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
#line 1 "C:\ProyectosCiclo3G10\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\_ViewImports.cshtml"
using HospiEnCasa.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41004a8f01e4046511c5d947c49a2c4f7981ba09", @"/Pages/VMedicos/GetMedico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"980668fccca30b420f458647ca7657270f532196", @"/Pages/_ViewImports.cshtml")]
    public class Pages_VMedicos_GetMedico : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Medico</h1>

<table class=""table table-bordered"">
    <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">Id</th>
      <th scope=""col"">Nombre</th>
      <th scope=""col"">Apellidos</th>
      <th scope=""col"">Telefono</th>
      <th scope=""col"">Genero</th>
      <th scope=""col"">Especialidad</th>
      <th scope=""col"">Codigo</th>
      <th scope=""col"">RegistroRethus</th>
    </tr>
  </thead>
    
  <tbody>
    <tr>
      
      <td>");
#nullable restore
#line 24 "C:\ProyectosCiclo3G10\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedico.cshtml"
     Write(Model.Medico.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 25 "C:\ProyectosCiclo3G10\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedico.cshtml"
     Write(Model.Medico.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          <td>");
#nullable restore
#line 26 "C:\ProyectosCiclo3G10\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedico.cshtml"
         Write(Model.Medico.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 27 "C:\ProyectosCiclo3G10\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedico.cshtml"
     Write(Model.Medico.NumeroTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 28 "C:\ProyectosCiclo3G10\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedico.cshtml"
     Write(Model.Medico.Genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 29 "C:\ProyectosCiclo3G10\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedico.cshtml"
     Write(Model.Medico.Especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 30 "C:\ProyectosCiclo3G10\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedico.cshtml"
     Write(Model.Medico.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 31 "C:\ProyectosCiclo3G10\HospiEnCasa.App\HospiEnCasa.App.Presentacion\Pages\VMedicos\GetMedico.cshtml"
     Write(Model.Medico.RegistroRethus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n   \r\n    \r\n  </tbody>\r\n    \r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.App.Presentacion.Pages.GetMedicoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.Presentacion.Pages.GetMedicoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.Presentacion.Pages.GetMedicoModel>)PageContext?.ViewData;
        public HospiEnCasa.App.Presentacion.Pages.GetMedicoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
