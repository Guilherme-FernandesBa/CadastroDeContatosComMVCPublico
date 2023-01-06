using CadastroContatosMVC.Models;
using CadastroContatosMVC.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;

namespace CadastroContatosMVC.Controllers
{ 
     public class ContatoController : Controller
    {
      
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController( IContatoRepositorio contatoRepositorio)
        {

            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
           
            List<ContatoModel> contatos = _contatoRepositorio.TodosRegistros();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Apagar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }
        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }
        public IActionResult ConfirmacaoApagarContato(int id)
        {


            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }











        [HttpPost]
        public IActionResult CriarContato(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }
        public IActionResult EditarContato(ContatoModel contato)
        {
            _contatoRepositorio.Editar(contato);
            return RedirectToAction("Index");
        }









        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
