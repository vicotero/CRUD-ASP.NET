#pragma checksum "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\editarUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7125539e0325b138ea9ad1efed4911b5cca0d41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_editarUsuario), @"mvc.1.0.view", @"/Views/Home/editarUsuario.cshtml")]
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
#line 2 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\editarUsuario.cshtml"
using Semhan.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\editarUsuario.cshtml"
using Semhan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7125539e0325b138ea9ad1efed4911b5cca0d41", @"/Views/Home/editarUsuario.cshtml")]
    public class Views_Home_editarUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Semhan.UsuarioSet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
<script src=""https://cdn.datatables.net/1.10.23/js/jquery.dataTables.min.js"" type=""text/javascript""></script>

<style>
 ");
            WriteLiteral(@"@import url(https://fonts.googleapis.com/css?family=Roboto:300);

.login-page {
  width: 360px;
  padding: 8% 0 0;
  margin: auto;
}
.form {
  position: relative;
  z-index: 1;
  background: #FFFFFF;
  max-width: 360px;
  margin: 0 auto 100px;
  padding: 45px;
  text-align: center;
  box-shadow: 0 0 20px 0 rgba(0, 0, 0, 0.2), 0 5px 5px 0 rgba(0, 0, 0, 0.24);
}
.form input {
  font-family: ""Roboto"", sans-serif;
  outline: 0;
  background: #f2f2f2;
  width: 100%;
  border: 0;
  margin: 0 0 15px;
  padding: 15px;
  box-sizing: border-box;
  font-size: 14px;
}
.form button {
  font-family: ""Roboto"", sans-serif;
  text-transform: uppercase;
  outline: 0;
  background: #4CAF50;
  width: 100%;
  border: 0;
  padding: 15px;
  color: #FFFFFF;
  font-size: 14px;
  -webkit-transition: all 0.3 ease;
  transition: all 0.3 ease;
  cursor: pointer;
}
.form button:hover,.form button:active,.form button:focus {
  background: #43A047;
}
.form .message {
  margin: 15px 0 0;
  color");
            WriteLiteral(@": #b3b3b3;
  font-size: 12px;
}
.form .message a {
  color: #4CAF50;
  text-decoration: none;
}
.form .register-form {
  display: none;
}
.container {
  position: relative;
  z-index: 1;
  max-width: 300px;
  margin: 0 auto;
}
.container:before, .container:after {
  content: """";
  display: block;
  clear: both;
}
.container .info {
  margin: 50px auto;
  text-align: center;
}
.container .info h1 {
  margin: 0 0 15px;
  padding: 0;
  font-size: 36px;
  font-weight: 300;
  color: #1a1a1a;
}
.container .info span {
  color: #4d4d4d;
  font-size: 12px;
}
.container .info span a {
  color: #000000;
  text-decoration: none;
}
.container .info span .fa {
  color: #EF3B3A;
}
body {
  background: #76b852; /* fallback for old browsers */
  background: -webkit-linear-gradient(right, #76b852, #8DC26F);
  background: -moz-linear-gradient(right, #76b852, #8DC26F);
  background: -o-linear-gradient(right, #76b852, #8DC26F);
  background: linear-gradient(to left, #76b852, #8DC26");
            WriteLiteral("F);\r\n  font-family: \"Roboto\", sans-serif;\r\n  -webkit-font-smoothing: antialiased;\r\n  -moz-osx-font-smoothing: grayscale;      \r\n}\r\n</style>\r\n\r\n\r\n<div class=\"login-page\">\r\n\r\n    <div class=\"form\">\r\n        <strong><p>Edicion de ");
#nullable restore
#line 118 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\editarUsuario.cshtml"
                         Write(Model.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 118 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\editarUsuario.cshtml"
                                       Write(Model.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></strong>\r\n        <form class=\"login-form\" asp-controller=\"Usuarios\" asp-action=\"editarUsuario\" method=\"post\" class=\"form-horizontal\" id=\"formEditarUsuario\">\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3506, "\"", 3523, 1);
#nullable restore
#line 120 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\editarUsuario.cshtml"
WriteAttributeValue("", 3514, Model.id, 3514, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"id\" name=\"Id\">\r\n            <label for=\"nombre\">Nombre</label>\r\n            <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3644, "\"", 3665, 1);
#nullable restore
#line 122 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\editarUsuario.cshtml"
WriteAttributeValue("", 3652, Model.nombre, 3652, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"nombre\" name=\"nombre\" placeholder=\"Nombre...\">\r\n            <label for=\"nombre\" >Apellido</label>\r\n            <input type=\"text\"");
            BeginWriteAttribute("value", " value=\"", 3821, "\"", 3844, 1);
#nullable restore
#line 124 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\editarUsuario.cshtml"
WriteAttributeValue("", 3829, Model.apellido, 3829, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\" id=\"apellido\" name=\"apellido\" placeholder=\"Apelldo...\">\r\n            <button id=\"btnAgregar\" class=\"btn btn-success\">Editar Usuario</button>\r\n        </form>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Semhan.UsuarioSet> Html { get; private set; }
    }
}
#pragma warning restore 1591
