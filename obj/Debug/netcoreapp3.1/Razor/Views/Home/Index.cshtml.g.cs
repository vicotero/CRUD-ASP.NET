#pragma checksum "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad393b062d1834880637660aaa109feff497d156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad393b062d1834880637660aaa109feff497d156", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Semhan.UsuarioSet>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/font-awesome/css/fontawesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/font-awesome/css/regular.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/font-awesome/css/solid.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad393b062d1834880637660aaa109feff497d1565127", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad393b062d1834880637660aaa109feff497d1566241", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad393b062d1834880637660aaa109feff497d1567355", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/js/bootstrap.bundle.min.js""></script>
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/css/bootstrap.min.css"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css"">
<link rel=""stylesheet"" href=""assets/css/style.css"">


");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<script src=\"https://use.fontawesome.com/bf66789927.js\"></script>\r\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/jquery/2.0.2/jquery.min.js\"></script>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad393b062d1834880637660aaa109feff497d1569122", async() => {
                WriteLiteral("\r\n    <div id=\"gradient\">\r\n        <h1>CRUD de Vicky 😜</h1>\r\n        <nav>\r\n            <a type=\"button\" class=\"btn btn-outline-danger\"");
                BeginWriteAttribute("href", " href=\'", 11763, "\'", 11805, 1);
#nullable restore
#line 314 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\Index.cshtml"
WriteAttributeValue("", 11770, Url.Action("crearUsuario", "Home"), 11770, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">Agregar Usuario <i class=""fas fa-user-plus""></i></a>
        </nav>
        <div id=""tabla"">
            <table id=""mitabla"" class=""listado"">
                <thead>
                    <tr>
                        <th><h2>Id</h2></th>
                        <th><h2>Nombre</h2></th>
                        <th><h2>Apellido</h2></th>
                        <th colspan=""2""><h2>Opciones</h2></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 327 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\Index.cshtml"
                     foreach (var usuario in Model)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 331 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\Index.cshtml"
                           Write(usuario.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 332 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\Index.cshtml"
                           Write(usuario.nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 333 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\Index.cshtml"
                           Write(usuario.apellido);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td class=\"icono1\"><a");
                BeginWriteAttribute("href", " href=\"", 12611, "\"", 12686, 1);
#nullable restore
#line 334 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\Index.cshtml"
WriteAttributeValue("", 12618, Url.Action("editarUsuario", "Home", new { usuarioId = usuario.id }), 12618, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><span class=\"fa fa-pencil-square-o fa-2x\"></span></a></td>\r\n                            <td class=\"icono\"><a href=\'#\'");
                BeginWriteAttribute("onclick", " onclick=\"", 12805, "\"", 12985, 21);
                WriteAttributeValue("", 12815, "confirm(\'¿Está", 12815, 14, true);
                WriteAttributeValue(" ", 12829, "seguro", 12830, 7, true);
                WriteAttributeValue(" ", 12836, "que", 12837, 4, true);
                WriteAttributeValue(" ", 12840, "quiere", 12841, 7, true);
                WriteAttributeValue(" ", 12847, "dar", 12848, 4, true);
                WriteAttributeValue(" ", 12851, "de", 12852, 3, true);
                WriteAttributeValue(" ", 12854, "baja", 12855, 5, true);
                WriteAttributeValue(" ", 12859, "a", 12860, 2, true);
                WriteAttributeValue(" ", 12861, "\'", 12862, 2, true);
                WriteAttributeValue(" ", 12863, "+", 12864, 2, true);
                WriteAttributeValue(" ", 12865, "\'", 12866, 2, true);
#nullable restore
#line 335 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\Index.cshtml"
WriteAttributeValue("", 12867, usuario.nombre, 12867, 15, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 12882, "?\')", 12882, 3, true);
                WriteAttributeValue(" ", 12885, "?", 12886, 2, true);
                WriteAttributeValue(" ", 12887, "window.location", 12888, 16, true);
                WriteAttributeValue(" ", 12903, "=", 12904, 2, true);
                WriteAttributeValue(" ", 12905, "\'", 12906, 2, true);
#nullable restore
#line 335 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\Index.cshtml"
WriteAttributeValue("", 12907, Url.Action("eliminarUsuario", "Home", new { usuarioId = usuario.id }), 12907, 70, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 12977, "\'", 12977, 1, true);
                WriteAttributeValue(" ", 12978, ":", 12979, 2, true);
                WriteAttributeValue(" ", 12980, "null", 12981, 5, true);
                EndWriteAttribute();
                WriteLiteral(" data-nombre=\"");
#nullable restore
#line 335 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                                       Write(usuario.nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"><span class=\"fa fa-trash fa-2x\"></span></a></td>\r\n");
                WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 339 "C:\Users\mvick\Documents\Trabajo\Semhan\Views\Home\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral(@"


    <footer class =""footer-basic"">
        <div id=""redessociales"">
            <a class=""smedia facebook"" href=""https://www.facebook.com/josernitos"">Uno</a>
            <a class=""smedia twitter"" href=""https://www.twitter.com/josernitos"">Dos</a>
            <a class=""smedia instagram"" href=""#"">Tres</a>
            <a class=""smedia youtube"" href=""#"">Cuatro</a>
            <a class=""smedia vimeo"" href=""#"">Cinco</a>
            <a class=""smedia email"" href=""#"">Seis</a>
        </div>
        <ul class=""list-inline"">
            <li class=""list-inline-item""><a href=""#"">Home</a></li>
            <li class=""list-inline-item""><a href=""#"">Services</a></li>
            <li class=""list-inline-item""><a href=""#"">About</a></li>
            <li class=""list-inline-item""><a href=""#"">Terms</a></li>
            <li class=""list-inline-item""><a href=""#"">Privacy Policy</a></li>
        </ul>
        <p class=""copyright"">Company Name ©MariaVictoriaOtero 2021</p>
        </footer>

<style>
    ");
            WriteLiteral("@charset \"UTF-8\";\r\n    ");
            WriteLiteral(@"@import 'https://fonts.googleapis.com/css?family=Raleway';

    /*body {
            font-family: 'Raleway', sans-serif;
            font-weight: 300;
            line-height: 1.42em;
            color: #4B4A4B;
            background-color: #FFDAC4;
            background: url(http://www.pixeden.com/media/k2/galleries/131/002-subtle-light-pattern-background-texture.jpg);
        }*/

    body {
        background-color: #000000;
        padding: 0px;
        margin: 0px;
    }

    #gradient {
        width: 100%;
        height: 100%;
        padding: 1px;
        margin: 0px;
    }

    .btn-outline-danger {
        color: #350133;
        border-color: #350133;
    }

        .btn-outline-danger:hover {
            background-color: #350133;
            border-color: #350133;
        }

    nav {
        text-align: center;
        margin: 20px;
    }

    h1 {
        font-size: 3em;
        font-weight: 300;
        line-height: 1em;
        text-align: center;");
            WriteLiteral(@"
        color: white;
        margin: 30px;
    }

    #tabla {
        height: 70%;
        overflow-y: auto;
       
    }

    .listado th h2 {
        font-weight: bold;
        font-size: 1em;
        text-align: left;
        color: #FFFFFF;
        display:block;
    }

    .listado td {
        font-weight: normal;
        font-size: 1em;
        -webkit-box-shadow: 0 2px 2px -2px #0E1119;
        -moz-box-shadow: 0 2px 2px -2px #0E1119;
        box-shadow: 0 2px 2px -2px #0E1119;
    }

    

    .listado {
        text-align: left;
        overflow-y: auto;
        width: 80%;
        margin: 0 auto;
        display: table;
        padding: 0 0 8em 0;
    }

   

        .listado td, .listado th {
            padding-bottom: 2%;
            padding-top: 2%;
            padding-left: 2%;
        }

        .listado tr:nth-child(odd) {
            background-color: #EEEAE7;
        }

        .listado tr:nth-child(even) {
            background-color");
            WriteLiteral(@": #FFFFFF;
        }

        .listado th {
            background-color: #350133;
            display:block;
        }

        .listado td:first-child {
            color: #FC1231;
        }

        .listado tr:hover {
            background-color: #F7C7F7;
            -webkit-box-shadow: 0 6px 6px -6px #0E1119;
            -moz-box-shadow: 0 6px 6px -6px #0E1119;
            box-shadow: 0 6px 6px -6px #0E1119;
        }

    td a {
        color: #4B4A4B;
    }

        td a:hover {
            color: #FFFFFF;
        }

    .listado td.icono:hover {
        background-color: #FC1231;
        box-shadow: #BA0F26 -1px 1px, #BA0F26 -2px 2px, #BA0F26 -3px 3px, #BA0F26 -4px 4px, #BA0F26 -5px 5px, #BA0F26 -6px 6px;
        transform: translate3d(6px, -6px, 0);
        transition-delay: 0s;
        transition-duration: 0.4s;
        transition-property: all;
        transition-timing-function: linear;
    }

    .listado td.icono1:hover {
        background-color: #19f510;");
            WriteLiteral(@"
        box-shadow: #22a813 -1px 1px, #22a813 -2px 2px, #22a813 -3px 3px, #22a813 -4px 4px, #22a813 -5px 5px, #22a813 -6px 6px;
        transform: translate3d(6px, -6px, 0);
        transition-delay: 0s;
        transition-duration: 0.4s;
        transition-property: all;
        transition-timing-function: linear;
    }



    /*css footer*/

   

    .footer-basic {
        padding: 15px;
        background-color: #350133;
        font-family: 'Roboto', sans-serif;
    }

        .footer-basic ul {
            padding: 0;
            list-style: none;
            text-align: center;
            font-size: 15px;
            line-height: 1.6;
            margin-bottom: 0;
            font-family: 'Roboto', sans-serif;
        }

        .footer-basic li {
            padding: 0 10px;
        }

        .footer-basic ul a {
            color: white;
            text-decoration: none;
            opacity: 0.8;
        }

            .footer-basic ul a:hover {
          ");
            WriteLiteral(@"      opacity: 1;
            }

        .footer-basic .social {
            text-align: center;
            padding-bottom: 25px;
        }

            /*.footer-basic .social > a {
                    font-size: 33px;
                    width: 40px;
                    height: 40px;
                    line-height: 40px;
                    display: inline-block;
                    text-align: center;
                    border-radius: 50%;
                    border: 1px solid #ccc;
                    margin: 0 8px;
                    color:  white;
                    opacity: 0.75;
                }*/

            .footer-basic .social > a:hover {
                opacity: 0.9;
            }

        .footer-basic .copyright {
            margin-top: 5px;
            text-align: center;
            font-size: 11px;
            color: white;
            margin-bottom: 0;
        }

    #redessociales {
        width: 64px;
        height: 64px;
        border-radiu");
            WriteLiteral(@"s: 75px;
        border: 5px solid #fff;
        left: 35%;
        position: relative;
        background: url(https://4.bp.blogspot.com/-gKMIOgeaEBY/UWHsOA382oI/AAAAAAAABpI/5GdyRTAeKII/s1600/share_core_square.jpg)
    }

    .smedia {
        position: absolute;
        -webkit-transition: left 0.5s cubic-bezier(0.1,0.8,0.9,1), opacity 1s linear;
        -moz-transition: left 0.5s cubic-bezier(0.1,0.8,0.9,1),opacity 1s linear;
        -o-transition: left 0.5s cubic-bezier(0.1,0.8,0.9,1), opacity 1s linear;
        display: inline;
        opacity: 0;
        width: 46px;
        height: 46px;
        z-index: 100;
        margin: 10px 0px 0px 20px;
        text-indent: -9999px;
        background: no-repeat;
        left: 3px;
    }

    #redessociales:hover .smedia {
        opacity: 1;
        transform: translate(0px,0);
        -webkit-transform: translate(0px,0);
        -o-transform: translate(0px,0);
        -moz-transform: translate(0px,0);
        margin: 5px 0px 0px 2p");
            WriteLiteral(@"x;
        position: absolute;
    }

        #redessociales:hover .smedia:nth-child(1) {
            position: absolute;
            left: 65px;
        }

        #redessociales:hover .smedia:nth-child(2) {
            position: absolute;
            left: 110px;
        }

        #redessociales:hover .smedia:nth-child(3) {
            position: absolute;
            left: 155px;
        }

        #redessociales:hover .smedia:nth-child(4) {
            position: absolute;
            left: 200px;
        }

        #redessociales:hover .smedia:nth-child(5) {
            position: absolute;
            left: 245px;
        }

        #redessociales:hover .smedia:nth-child(6) {
            position: absolute;
            left: 290px;
        }

    .smedia.facebook {
        background: url(https://4.bp.blogspot.com/-49s_0_9mdVo/UWHsMIvJBNI/AAAAAAAABn8/6bVMlN4Qz7Y/s1600/bubble_facebook_share_button.png);
    }

    .smedia.twitter {
        background: url(https://2.bp");
            WriteLiteral(@".blogspot.com/-3r8sHe1Qy5M/UWHsNMDDzHI/AAAAAAAABog/q3V7mYirmOY/s1600/bubble_twitter_share_button.png);
    }

    .smedia.email {
        background: url(https://3.bp.blogspot.com/-ZhFqBhp79cA/UWHsMBmPxsI/AAAAAAAABn4/O8k_pGf1oCU/s1600/bubble_email_share_button.png);
    }

    .smedia.instagram {
        background: url(https://1.bp.blogspot.com/-FSkby0cXU_8/UWHsMis8c2I/AAAAAAAABoQ/y8coyc5ystc/s1600/bubble_instagram_share_button.png);
    }

    .smedia.youtube {
        background: url(https://4.bp.blogspot.com/-x2oyT1dBzwA/UWHsNtcWXVI/AAAAAAAABo8/8kCXTVMbM6Y/s1600/bubble_youtube_share_button.png);
    }

    .smedia.vimeo {
        background: url(https://2.bp.blogspot.com/-01SWPeX-584/UWHsNim9CAI/AAAAAAAABo4/Z9jMox_9UrE/s1600/bubble_vimeo_share_button.png);
    }

    .smedia:hover {
        background-position: 0 -46px;
    }
</style>

<script>
    var colors = new Array(
        [62, 35, 255],
        [60, 255, 60],
        [255, 35, 98],
        [45, 175, 230],
        [255");
            WriteLiteral(@", 0, 255],
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
        var b1 = Math.round(istep * c0_0[2] + step * c0_1[2]);
        var color1 = ""rgb("" + r1 + "","" + g1 + "","" + b1 + "")"";

        var r2 = Math.round(istep * c1_0[0] + step * c1_1[0]);
        var g2 = Math.round(istep * c1_0[1] + step * c1_1[1]);
        var b2 = Math.round(istep * c1_0[2] + step * c1_1[2");
            WriteLiteral(@"]);
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
            colorIndices[1] = (colorIndices[1] + Math.floor(1 + Math.random() * (colors.length - 1))) % colors.length;
            colorIndices[3] = (colorIndices[3] + Math.floor(1 + Math.random() * (colors.length - 1))) % colors.length;

        }
    }

    setInterval(updateGradient, 10);

    $(document).ready(function () {
        $('#hola').DataTable({ ""paging"": true });
        ");
            WriteLiteral("$(\'.dataTables_length\').addClass(\'bs-select\');\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Semhan.UsuarioSet>> Html { get; private set; }
    }
}
#pragma warning restore 1591
