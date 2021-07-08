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

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Usuario novoUsuario = new Usuario();
            Random rdn = new Random();

            novoUsuario.Id_usuario = rdn.Next(999999999).ToString();
            novoUsuario.Email = form["Email"];
            novoUsuario.Nome = form["Nome"];
            novoUsuario.Username = form["Username"];
            novoUsuario.Senha = form["Senha"];

            UsuarioModel.Criar(novoUsuario);

            return LocalRedirect("~/");

        }
    }

}