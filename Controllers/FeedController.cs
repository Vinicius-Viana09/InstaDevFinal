using InstaDevFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstaDevFinal.Controllers
{
    public class FeedController : Controller
    {
        Post Postmodel = new Post();
        public IActionResult index(){
            ViewBag.Posts = Postmodel.LerTodos();
            ViewBag.Usuarios = Usuariomodel.LerTodos();
            return View();
        }

    }
}