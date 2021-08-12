using System.Collections.Generic;
using Atividade02.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atividade02.Controllers
{
    public class PacoteController : Controller
    {
        public IActionResult CadastroPacote(){
            return View();
        }
        
        [HttpPost]
        public IActionResult CadastroPacote(Pacote p)
        {
            PacoteRepository pr = new PacoteRepository();
            pr.Insert(p);
            return View("PacoteCadastrado");
        }

        public IActionResult PacoteCadastrado(){
            return View();
        }

        public IActionResult ListarPacote()
        {
            PacoteRepository pr = new PacoteRepository();
            List<Pacote> lista = pr.Listar();
            return View(lista);
        }

        public IActionResult EditarPacote(){
            return View();
        }

        [HttpPost]
        public IActionResult EditarPacote(Pacote p){
            PacoteRepository pr = new PacoteRepository();
            pr.Editar (p);
            return View("PacoteEditado");
        }

        public IActionResult PacoteEditado(){
            return View();
        }

        public IActionResult ExcluirPacote(){
            return View();
        }

        [HttpPost]
        public IActionResult ExcluirPacote(Pacote p){
            PacoteRepository pr = new PacoteRepository();
            pr.Excluir (p);
            return View("PacoteExcluido");
        }

        public IActionResult PacoteExcluido(){
            return View();
        }
    }
}