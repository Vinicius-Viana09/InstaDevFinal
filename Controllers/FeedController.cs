using InstaDevFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstaDevFinal.Controllers
{
    public class FeedController : Controller
    {
        Post Postmodel = new Post();

        Usuario Usuariomodel = new Usuario();
        public IActionResult index(){
            ViewBag.Posts = Postmodel.LerTodos();
            ViewBag.Usuarios = Usuariomodel.LerUsuarios();
            return View();
        }

    }
}