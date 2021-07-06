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

                novoUsuario.Imagem = file.FileName;
            }
            else
            {
                novoUsuario.Imagem = "padrao.png";
            }

            usuarioModel.AlterarDados(novoUsuario);

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
