using InstaDevFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstaDevFinal.Controllers
{
    public class PerfilController : Controller
    {
        Usuario UsuarioModel = new Usuario();
        Post PostModel = new Post();

        [Route("Index/{Id_usuario}")]
        public IActionResult Index(int Id_usuario)
        {
            ViewBag.Usuarios = UsuarioModel.LerTodosUsuarios(Id_usuario);
            ViewBag.Posts = UsuarioModel.LerTodosPost();
            return View();
        }

        [Route("Excluir/{Id_post}")]
        public IActionResult Excluir(int Id_post)
        {
            UsuarioModel.Deletar(Id_post);
            ViewBag.Usuarios = UsuarioModel.LerTodosPost();
            return LocalRedirect("~/Perfil/Index");
        }
    }
}