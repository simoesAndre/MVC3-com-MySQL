using System.Collections.Generic;
using Atividade02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Atividade02.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Login(){
            return View();
        }

        [HttpPost]
        public IActionResult Login(Usuario u){
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.Login(u);

            if(usuario != null){
                HttpContext.Session.SetInt32("id", usuario.Id);
                HttpContext.Session.SetString("nome", usuario.Nome);
                HttpContext.Session.SetInt32("tipo", usuario.Tipo);
                return Redirect("Logado");
            }
            else{
                ViewBag.Mensagem = "Erro, Usuário ou Senha Inválidos";
                return View();
            }    
        }

        public IActionResult Logado(){
            return View();
        }

        public IActionResult CadastroUsuario()
        {
            if (HttpContext.Session.GetInt32("tipo") != 1)
                return RedirectToAction("AcessoNegado");
            return View();
        }
        
        [HttpPost]
        public IActionResult CadastroUsuario(Usuario u)
        {
            UsuarioRepository ur = new UsuarioRepository();
            ur.Insert(u);
            return View("UsuarioCadastrado");
        }

        public IActionResult UsuarioCadastrado(){
            return View();
        }

        public IActionResult ListarUsuario()
        {
            if (HttpContext.Session.GetInt32("tipo") != 1)
                return RedirectToAction("AcessoNegado2");
            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> lista = ur.Listar();
            return View(lista);
        }

        public IActionResult EditarUsuario(){
            if (HttpContext.Session.GetInt32("tipo") != 1)
                return RedirectToAction("AcessoNegado3");
            return View();
        }

        [HttpPost]
        public IActionResult EditarUsuario(Usuario u){
            UsuarioRepository ur = new UsuarioRepository();
            ur.Editar (u);
            return View("UsuarioEditado");
        }

        public IActionResult UsuarioEditado(){
            return View();
        }

        public IActionResult ExcluirUsuario(){
            if (HttpContext.Session.GetInt32("tipo") != 1)
                return RedirectToAction("AcessoNegado4");
            return View();
        }

        [HttpPost]
        public IActionResult ExcluirUsuario(Usuario u){
            UsuarioRepository ur = new UsuarioRepository();
            ur.Excluir (u);
            return View("UsuarioExcluido");
        }

        public IActionResult UsuarioExcluido(){
            return View();
        }

        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return View();
        }

        public IActionResult AcessoNegado(){
            return View();
        }

        public IActionResult AcessoNegado2(){
            return View();
        }

        public IActionResult AcessoNegado3(){
            return View();
        }

        public IActionResult AcessoNegado4(){
            return View();
        }
    }
}