using System;
using InstaDevFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDevFinal.Controllers
{
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

        public IActionResult Postar(IFormCollection form)
        {
            Post novopost = new Post();
            Random rdn = new Random();
            
            novopost.Id_post = rdn.Next(999999999).ToString();
            novopost.texto_post = form["texto_post"];
            novopost.imagem = form["Imagem"];

            Postmodel.PostarPost(novopost);
            ViewBag.Posts = Postmodel.LerTodosPost();

            return LocalRedirect("~/");
        }

    }
}