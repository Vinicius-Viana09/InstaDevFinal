#pragma checksum "C:\Users\guilherme_2\Documents\trabalhos do leo\Senai\TUDO DE C#\InstaDevFinal\Views\Perfil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d54a460f651021d5860c67112076fdf296ea88e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfil_Index), @"mvc.1.0.view", @"/Views/Perfil/Index.cshtml")]
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
#line 1 "C:\Users\guilherme_2\Documents\trabalhos do leo\Senai\TUDO DE C#\InstaDevFinal\Views\_ViewImports.cshtml"
using InstaDevFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\guilherme_2\Documents\trabalhos do leo\Senai\TUDO DE C#\InstaDevFinal\Views\_ViewImports.cshtml"
using InstaDevFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d54a460f651021d5860c67112076fdf296ea88e6", @"/Views/Perfil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f39a670a065805d1ab49a5c8511b2331a49de59", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\guilherme_2\Documents\trabalhos do leo\Senai\TUDO DE C#\InstaDevFinal\Views\Perfil\Index.cshtml"
  
    ViewData["Title"] = "Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""container_perfil"">
    <div class=""box_perfil"">
        <div class=""img_perfil"">
            <img src=""assets/thank-you 3.png"" alt=""imagem de perfil"">
        </div>

        <div class=""box_info"">
            <h1 class=""username"">yes_baby</h1>
            <div class=""box_info_perfil"">
                <span>0 Publicações</span>
                <span>128 Seguindo</span>
                <span>214 Seguidores</span>
            </div>
            <span class=""nome_usuario"">Marcos Jeeves</span>
        </div>
    </div>
</section>

<div class=""linha"">
    <hr>
    </hr>
</div>

<div class=""publi"">
    <img src=""assets/publicacoes.png""");
            BeginWriteAttribute("alt", " alt=\"", 737, "\"", 743, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <span>Publicações</span>
</div>


<section class=""container_post"">
    <div class=""box_post_organizacao"">
        <img src=""assets/Rectangle 4.png"" alt=""Foto do Post"">
        <div class=""box_post"">
            <div class=""box_info_posts"">
                <img src=""assets/thank-you 4.png"" alt=""Imagem de Perfil"">
                <div class=""box_local_post"">
                    <span class=""nome_usuario"">Marcos Jeeves</span>
                    <span class=""localizacao"">Rio de Janeiro</span>
                </div>
            </div>
            <div class=""box_curtir"">
                <img src=""assets/like.png"" alt=""Like"">
                <img src=""assets/comentario.png"" alt=""Comentarios"">
            </div>
            <span class=""contador_curtidas"">1954 Curtidas</span>

            <div class=""box_comentario"">
                <div class=""ajustar_tamanho_comentario"">
                    <span class=""nome_usuario_comentario"">fausto_silva</span>
                    <span class=""co");
            WriteLiteral(@"mentario"">Esse cara é fera bixo!!</span>
                    <img src=""assets/like.png"" alt=""Like"">
                </div>
                <div class=""ajustar_tamanho_comentario"">
                    <span class=""nome_usuario_comentario"">yes_baby</span>
                    <span class=""comentario"">thank you</span>
                    <img src=""assets/like.png"" alt=""Like"">
                </div>
                <div class=""ajustar_tamanho_comentario"">
                    <span class=""nome_usuario_comentario"">adriano_stark</span>
                    <span class=""comentario"">Quando eu adormecer vou sonhar com você. É sempre você</span>
                    <img src=""assets/like.png"" alt=""Like"">
                </div>
                <div class=""ajustar_tamanho_comentario"">
                    <span class=""nome_usuario_comentario"">yes_baby</span>
                    <span class=""comentario"">Yes baby!!</span>
                    <img src=""assets/like.png"" alt=""Like"">
                </div>
       ");
            WriteLiteral("     </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
