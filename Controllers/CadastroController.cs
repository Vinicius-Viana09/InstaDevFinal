using System;
using InstaDevFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace InstaDevFinal.Controllers
{
    [Route("Cadastro")]
    public class CadastroController : Controller
    {
        Usuario UsuarioModel = new Usuario();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Usuario novoUsuario = new Usuario();
            Random rdn = new Random();



            novoUsuario.IdUsuario = rdn.Next(999999999);
            novoUsuario.NomeCompleto = form["NomeCompleto"];
            novoUsuario.NomeUsuario = form["NomeUsuario"];
            novoUsuario.Email = form["Email"];
            novoUsuario.Senha = form["Senha"];

            UsuarioModel.Criar(novoUsuario);

            return LocalRedirect("~/");

        }
    }

}