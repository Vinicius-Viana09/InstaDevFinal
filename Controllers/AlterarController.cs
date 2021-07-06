using System;
using System.IO;
using InstaDevFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace InstaDevFinal.Controllers
{
    [Route("Cadastro")]
    public class AlterarController : Controller
    {
        Usuario usuarioModel = new Usuario();
        public IActionResult Index()
        {
            return View();
        }

    
        [Route("Deletar/{id}")]
        public IActionResult Deletar(int id)
        {
            usuarioModel.DeletarConta(id);
            ViewBag.Usuario = usuarioModel.LerUsuarios();
            return LocalRedirect("~/Excluir/Index");
        }
    }

}
