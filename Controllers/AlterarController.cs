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

        [Route("Alterar")]
        public IActionResult Alterar(IFormCollection form)
        {
            Usuario novoUsuario = new Usuario();

            novoUsuario.NomeCompleto = form[""];
            novoUsuario.NomeUsuario = form[""];
            novoUsuario.Email = form[""];

            //usuarioModel.Cadastrar(novoUsuario);

            ViewBag.Usuarios = usuarioModel.LerUsuarios();

            return LocalRedirect("~/");
        }


        [Route("Deletar/{id}")]
        public IActionResult Deletar(int id)
        {
            usuarioModel.DeletarConta(id);
            ViewBag.Usuario = usuarioModel.LerUsuarios();
            return LocalRedirect("~/");
        }
    }

}
