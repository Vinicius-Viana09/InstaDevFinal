using System;
using System.IO;
using InstaDevFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDevFinal.Controllers
{
    [Route("Feed")]
    public class FeedController : Controller
    {
        Post Postmodel = new Post();

        Usuario Usuariomodel = new Usuario();
        public IActionResult index()
        {
            ViewBag.Posts = Postmodel.LerTodosPost();
            ViewBag.Usuarios = Usuariomodel.LerTodosUsuarios();
            return View();
        }

        [Route("Postar")]
        public IActionResult Postar(IFormCollection form)
        {
            Post novopost = new Post();
            Random rdn = new Random();
            
            novopost.Id_post = rdn.Next(999999999).ToString();
            novopost.texto_post = form["texto_post"];
            novopost.Username = HttpContext.Session.GetString("Username");
            /* novopost.imagem = form["Imagem"]; */
             if (form.Files.Count > 0)
            {

                var file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Posts");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/", folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novopost.imagem = file.FileName;

            }
            else
            {
                novopost.imagem = "padrao.jpg";
            }

            Postmodel.PostarPost(novopost);
            ViewBag.Posts = Postmodel.LerTodosPost();

            return LocalRedirect("~/Feed");
        }

    }
}