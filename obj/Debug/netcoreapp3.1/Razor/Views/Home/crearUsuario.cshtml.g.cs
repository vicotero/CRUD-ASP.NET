#pragma checksum "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\crearUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c3639578d788c55424897bb1fb53dfb61a62fec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_crearUsuario), @"mvc.1.0.view", @"/Views/Home/crearUsuario.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c3639578d788c55424897bb1fb53dfb61a62fec", @"/Views/Home/crearUsuario.cshtml")]
    public class Views_Home_crearUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h2>Nuevo Usuario</h2>
<hr />
<form asp-controller=""Home"" asp-action=""crearUsuarioPost"" method=""post"" class=""form-horizontal"" id=""formNuevoUsuario"">
    <div id=""esExternoDiv"" class=""form-group"">
        <div class=""col-sm-10"">
            <input type=""text"" class=""form-control"" id=""esExterno"" name=""Nombre"" placeholder=""Nombre"">
        </div>
    </div>

</form>

<div class=""form-group"">
    <div class=""col-sm-offset-2 col-sm-10"">
        <button id=""btnAgregar"" type=""button"" name=""boton"" class=""btn btn-success"">Agregar Usuario</button>
    </div>
</div>

<script>

        function fetchPost(url, body) {
            return fetch(url,
                {
                    method: ""POST"",
                    body: body,
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    }
                })
                .then(res => {
                    return res.json();
       ");
            WriteLiteral(@"         })
                .then(respJson => {
                    return respJson;
                });
        }


    $(""#btnAgregar"").click(function() {

            //Datos del Form
            var nuevoUsuario = {};
            var formNuevoUsuario = document.getElementById('formNuevoUsuario');
            var formData = new FormData(formNuevoUsuario);
            var formElems = document.getElementById('formNuevoUsuario').elements;
            for (let i = 0; i < formElems.length; i++) {
                nuevoUsuario[formElems[i].name] = formElems[i].value;
            }
            let object = {};
            formData.forEach(function(value, key) {
                if (!(key === ""__RequestVerificationToken""))
                    object[key] = value;
            });


            let body = JSON.stringify(object);
            console.log(body);
            let url = '");
#nullable restore
#line 59 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\crearUsuario.cshtml"
                  Write(Url.Action("crearUsuario", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\r\n        fetchPost(url, body).then(respJson => {\r\n\r\n            if (!respJson.error) {\r\n                window.location = `");
#nullable restore
#line 64 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\crearUsuario.cshtml"
                              Write(Url.Action("Index","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("`;\r\n            } else {\r\n                console.log(respJson.msj);\r\n            }\r\n                })\r\n                .catch();\r\n        });\r\n\r\n</script>\r\n\r\n\r\n");
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