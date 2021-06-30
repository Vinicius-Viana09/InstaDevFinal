using InstaDevFinal.Models;
using Microsoft.AspNetCore.Mvc;

namespace InstaDevFinal.Controllers
{
    public class PerfilController : Controller
    {
        Usuario UsuarioModel = new Usuario();

        [Route("Index")]
        public IActionResult Index()
        {
            ViewBag.Usuarios = UsuarioModel.LerTodos();
            return View();
        }

        [Route("Excluir/{Id_post}")]
        public IActionResult Excluir(int Id_post)
        {
            UsuarioModel.Deletar(Id_post);
            ViewBag.Usuarios = UsuarioModel.LerTodos();
            return LocalRedirect("~/Perfil/Index");
        }
    }
}