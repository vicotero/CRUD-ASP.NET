#pragma checksum "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\crearUsuario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e22b92ba2ea85170f83bbbefc283f5436a64d573"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e22b92ba2ea85170f83bbbefc283f5436a64d573", @"/Views/Home/crearUsuario.cshtml")]
    public class Views_Home_crearUsuario : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js"" integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"" integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"" integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>
<script src=""https://cdn.datatables.net/1.10.23/js/jquery.dataTables.min.js"" type=""text/javascript""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/2.0.2/jquery.min.js""></script>

<style>");
            WriteLiteral("\n    ");
            WriteLiteral(@"@import url(https://fonts.googleapis.com/css?family=Roboto:400,300,100,500);

    body {
        background-color: #000000;
        padding: 0px;
        margin: 0px;
    }

    #gradient {
        width: 100%;
        height: 100%;
        padding: 0px;
        margin: 0px;
    }
    /*body {
        background-color: #FFDAC4;
        background: url(http://www.pixeden.com/media/k2/galleries/131/002-subtle-light-pattern-background-texture.jpg);
    }*/
    html {
        margin: 0;
        height: 100%;
    }

    input {
        border: none;
    }

    button:focus {
        outline: none;
    }

    ::-webkit-input-placeholder {
        color: rgba(255, 255, 255, 0.65);
    }

        ::-webkit-input-placeholder .input-line:focus {
            color: #fff;
        }

    .highlight {
        color: rgba(255, 255, 255, 0.8);
        font-weight: 400;
        cursor: pointer;
        transition: color .2s ease;
    }

        .highlight:hover {
            colo");
            WriteLiteral(@"r: #fff;
            transition: color .2s ease;
        }

    .spacing {
        -webkit-box-flex: 1;
        -webkit-flex-grow: 1;
        -ms-flex: 1;
        flex-grow: 1;
        height: 120px;
        font-weight: 300;
        text-align: center;
        margin-top: 10px;
        color: rgba(255, 255, 255, 0.65)
    }

    .input-line:focus {
        outline: none;
        border-color: #fff;
        -webkit-transition: all .2s ease;
        transition: all .2s ease;
    }

    .ghost-round {
        cursor: pointer;
        background: none;
        border: 1px solid rgba(255, 255, 255, 0.65);
        border-radius: 25px;
        color: rgba(255, 255, 255, 0.65);
        -webkit-align-content:flex-end;
        -ms-flex-item-align: end;
        align-self: flex-end;
        font-size: 19px;
        font-size: 1.2rem;
        font-family: roboto;
        font-weight: 300;
        line-height: 2.5em;
        margin-top: auto;
        margin-bottom: 25px;
        -we");
            WriteLiteral(@"bkit-transition: all .2s ease;
        transition: all .2s ease;
    }

        .ghost-round:hover {
            background: rgba(255, 255, 255, 0.15);
            color: #fff;
            -webkit-transition: all .2s ease;
            transition: all .2s ease;
        }

    .input-line {
        background: none;
        margin-bottom: 10px;
        line-height: 2.4em;
        color: #fff;
        font-family: roboto;
        font-weight: 300;
        letter-spacing: 0px;
        letter-spacing: 0.02rem;
        font-size: 19px;
        font-size: 1.2rem;
        border-bottom: 1px solid rgba(255, 255, 255, 0.65);
        -webkit-transition: all .2s ease;
        transition: all .2s ease;
    }

    .full-width {
        width: 100%;
    }

    .input-fields {
        margin-top: 25px;
    }

    .container {
        display: -webkit-box;
        display: -webkit-flex;
        display: -ms-flexbox;
        display: flex;
        -webkit-box-align: center;
        -web");
            WriteLiteral(@"kit-align-items: center;
        -ms-flex-align: center;
        align-items: center;
        -webkit-box-pack: center;
        -webkit-justify-content: center;
        -ms-flex-pack: center;
        justify-content: center;
        
        height: 100%;
    }

    .content {
        padding-left: 25px;
        padding-right: 25px;
        display: -webkit-box;
        display: -webkit-flex;
        display: -ms-flexbox;
        display: flex;
        -webkit-flex-flow: column;
        -ms-flex-flow: column;
        flex-flow: column;
        z-index: 5;
    }

    .welcome {
        font-weight: 200;
        margin-top: 75px;
        text-align: center;
        font-size: 40px;
        font-size: 2.5rem;
        letter-spacing: 0px;
        letter-spacing: 0.05rem;
    }

    .subtitle {
        text-align: center;
        line-height: 1em;
        font-weight: 100;
        letter-spacing: 0px;
        letter-spacing: 0.02rem;
    }

    .menu {
        background:");
            WriteLiteral(@" rgba(0, 0, 0, 0.2);
        width: 100%;
        height: 50px;
    }

    .window {
        z-index: 100;
        color: #fff;
        font-family: roboto;
        position: relative;
        display: -webkit-box;
        display: -webkit-flex;
        display: -ms-flexbox;
        display: flex;
        -webkit-flex-flow: column;
        -ms-flex-flow: column;
        flex-flow: column;
        box-shadow: 0px 15px 50px 10px rgba(0, 0, 0, 0.2);
        box-sizing: border-box;
        height: 560px;
        width: 360px;
        background: #fff;
        background: url('https://pexels.imgix.net/photos/27718/pexels-photo-27718.jpg?fit=crop&w=1280&h=823') top left no-repeat;
    }

    .overlay {
        background: -webkit-linear-gradient(#8CA6DB, #B993D6);
        background: linear-gradient(#8CA6DB, #B993D6);
        opacity: 0.85;
        filter: alpha(opacity=85);
        height: 560px;
        position: absolute;
        width: 360px;
        z-index: 1;
    }

    .b");
            WriteLiteral(@"old-line {
        background: #e7e7e7;
        position: absolute;
        top: 0px;
        bottom: 0px;
        margin: auto;
        width: 100%;
        height: 360px;
        z-index: 1;
        opacity: 0.1;
        background: url('https://pexels.imgix.net/photos/27718/pexels-photo-27718.jpg?fit=crop&w=1280&h=823') left no-repeat;
        background-size: cover;
    }

    ");
            WriteLiteral(@"@media (max-width: 500px) {
        .window {
            width: 100%;
            height: 100%;
        }

        .overlay {
            width: 100%;
            height: 100%;
        }

        .col-sm-10{
            max-width:100%;
        }
    }

    .col-sm-10 {
        max-width: 100%;
    }
</style>





");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e22b92ba2ea85170f83bbbefc283f5436a64d5739734", async() => {
                WriteLiteral(@"
    <div id=""gradient"">
        <div class='bold-line'></div>
        <div class='container'>
            <div class='window'>
                <div class='overlay'></div>
                <div class='content'>
                    <div class='welcome'>Nuevo Usuario</div>
                    <div class='input-fields'>
                        <form asp-controller=""Home"" asp-action=""crearUsuarioPost"" method=""post"" class=""form-horizontal"" id=""formNuevoUsuario"">
                            <div id=""esExternoDiv"" class=""form-group"">
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""input-line full-width"" id=""esExterno"" name=""nombre"" placeholder=""Nombre"">
                                </div>
                            </div>
                            <div id=""esExternoDiv"" class=""form-group"">
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""input-line full-widt");
                WriteLiteral(@"h"" id=""esExterno"" name=""apellido"" placeholder=""Apellido"">
                                </div>
                            </div>
                            <button id=""btnAgregar"" type=""button"" name=""boton"" class='ghost-round full-width'>Agregar Usuario</button>
                        </form>
                    </div>

                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
<!--<div class=""form-group"">
    <div class=""col-sm-offset-2 col-sm-10"">
        <button id=""btnAgregar"" type=""button"" name=""boton"" class=""btn btn-success"">Agregar Usuario</button>
    </div>
</div>-->

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
                })
                .then(respJson => {
                    return respJson;
                });
        }


    $(""#btnAgregar"").click(function() {

            //Datos del Form
            var nuevoUsuario = {};
            var formNuevoUsuario = document.getElementById('formNuevoUsuario');
            var formData = new FormData(formNuevoUsuario)");
            WriteLiteral(@";
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
#line 349 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\crearUsuario.cshtml"
                  Write(Url.Action("crearUsuarioPost", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n\r\n        fetchPost(url, body).then(respJson => {\r\n\r\n            if (!respJson.error) {\r\n                window.location = `");
#nullable restore
#line 354 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\crearUsuario.cshtml"
                              Write(Url.Action("Index","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"`;
            } else {
                console.log(respJson.msj);
            }
                })
                .catch();
        });


    var colors = new Array(
        [62, 35, 255],
        [60, 255, 60],
        [255, 35, 98],
        [45, 175, 230],
        [255, 0, 255],
        [255, 128, 0]);

    var step = 0;
    //color table indices for: 
    // current color left
    // next color left
    // current color right
    // next color right
    var colorIndices = [0, 1, 2, 3];

    //transition speed
    var gradientSpeed = 0.002;

    function updateGradient() {

        if ($ === undefined) return;

        var c0_0 = colors[colorIndices[0]];
        var c0_1 = colors[colorIndices[1]];
        var c1_0 = colors[colorIndices[2]];
        var c1_1 = colors[colorIndices[3]];

        var istep = 1 - step;
        var r1 = Math.round(istep * c0_0[0] + step * c0_1[0]);
        var g1 = Math.round(istep * c0_0[1] + step * c0_1[1]);
        var b1 = Math.round(");
            WriteLiteral(@"istep * c0_0[2] + step * c0_1[2]);
        var color1 = ""rgb("" + r1 + "","" + g1 + "","" + b1 + "")"";

        var r2 = Math.round(istep * c1_0[0] + step * c1_1[0]);
        var g2 = Math.round(istep * c1_0[1] + step * c1_1[1]);
        var b2 = Math.round(istep * c1_0[2] + step * c1_1[2]);
        var color2 = ""rgb("" + r2 + "","" + g2 + "","" + b2 + "")"";

        $('#gradient').css({
            background: ""-webkit-gradient(linear, left top, right top, from("" + color1 + ""), to("" + color2 + ""))""
        }).css({
            background: ""-moz-linear-gradient(left, "" + color1 + "" 0%, "" + color2 + "" 100%)""
        });

        step += gradientSpeed;
        if (step >= 1) {
            step %= 1;
            colorIndices[0] = colorIndices[1];
            colorIndices[2] = colorIndices[3];

            //pick two new target color indices
            //do not pick the same as the current one
            colorIndices[1] = (colorIndices[1] + Math.floor(1 + Math.random() * (colors.length - 1))) % colors");
            WriteLiteral(".length;\r\n            colorIndices[3] = (colorIndices[3] + Math.floor(1 + Math.random() * (colors.length - 1))) % colors.length;\r\n\r\n        }\r\n    }\r\n\r\n    setInterval(updateGradient, 10);\r\n</script>\r\n\r\n\r\n");
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
