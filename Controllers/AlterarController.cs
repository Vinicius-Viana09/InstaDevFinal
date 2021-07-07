using System;
using System.IO;
using InstaDevFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace InstaDevFinal.Controllers
{
    [Route("AlterarUsuario")]
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

            novoUsuario.Nome = form[""];
            novoUsuario.Username = form[""];
            novoUsuario.Email = form[""];

            //usuarioModel.Cadastrar(novoUsuario);
            ViewBag.Usuarios = usuarioModel.LerTodosUsuarios();

            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Usuarios");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novoUsuario.Foto = file.FileName;
            }
            else
            {
                novoUsuario.Foto = "padrao.png";
            }

            usuarioModel.AlterarDados(novoUsuario);

            return LocalRedirect("~/");
        }


        [Route("Deletar/{Id_usuario}")]
        public IActionResult Deletar(int Id_usuario)
        {
            usuarioModel.DeletarConta(Id_usuario);
            ViewBag.Usuario = usuarioModel.LerTodosUsuarios();
            return LocalRedirect("~/");
        }
    }

}
