#pragma checksum "C:\Users\CCE\Desktop\AtividadeMVC3\Atividade02\Views\Usuario\AcessoNegado3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6fb61201037529a610cce5fceb2c4d9e25e5a0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_AcessoNegado3), @"mvc.1.0.view", @"/Views/Usuario/AcessoNegado3.cshtml")]
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
#line 1 "C:\Users\CCE\Desktop\AtividadeMVC3\Atividade02\Views\_ViewImports.cshtml"
using Atividade02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CCE\Desktop\AtividadeMVC3\Atividade02\Views\_ViewImports.cshtml"
using Atividade02.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6fb61201037529a610cce5fceb2c4d9e25e5a0a", @"/Views/Usuario/AcessoNegado3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afd929cd8f75eb8fa481411d4c22f3260f5cb664", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_AcessoNegado3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\CCE\Desktop\AtividadeMVC3\Atividade02\Views\Usuario\AcessoNegado3.cshtml"
  
    ViewData["Title"] = "Acesso Negado -";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h4>Acesso Negado - somente o Usuário Administrador pode fazer a edição de usuários</h4>
<p style=""padding-top: 20px;"">O que deseja fazer agora:</p>
<div>
    <a href=""/Pacote/CadastroPacote"" style=""color: black;"">Cadastrar pacote turístico</a>
</div>
<div>
    <a href=""/Pacote/ListarPacote"" style=""color: black;"">Ver a lista de pacotes turísticos</a>
</div>
<div>
    <a href=""/Pacote/EditarPacote"" style=""color: black;"">Editar pacote turístico</a>
</div>
<div>
    <a href=""/Pacote/ExcluirPacote"" style=""color: black;"">Excluir pacote turístico</a>
</div>
<div>
    <a href=""Logout"" style=""color: black;"">Sair do sistema</a>
</div>
");
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
