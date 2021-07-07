using InstaDevFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstaDevFinal.Controllers
{
    public class PerfilController : Controller
    {
        Usuario UsuarioModel = new Usuario();
        Post PostModel = new Post();

        [Route("Perfil/Index")]
        public IActionResult Index()
        {
            ViewBag.Usuarios = UsuarioModel.LerTodosUsuarios();
            ViewBag.Posts = PostModel.LerTodosPost();
            /* return LocalRedirect("~/Perfil/Index"); */
            return View();
        }

        [Route("Excluir/{Id_post}")]
        public IActionResult Excluir(int Id_post)
        {
            PostModel.Deletar(Id_post);
            ViewBag.Posts = PostModel.LerTodosPost();
            return LocalRedirect("~/Perfil/Index");
        }
    }
}