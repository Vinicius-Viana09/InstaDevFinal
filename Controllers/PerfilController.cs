using InstaDevFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDevFinal.Controllers
{
    public class PerfilController : Controller
    {
        Usuario UsuarioModel = new Usuario();
        Post PostModel = new Post();

        public IActionResult Index()
        {
            ViewBag.User = HttpContext.Session.GetString("UserName");
            ViewBag.PostPerfil = PostModel.PostPerfil(HttpContext.Session.GetString("UserName"));

            if (ViewBag.User != null)
            {
                return View();
            }

            return LocalRedirect("~/Home");
        }
        
        /* [Route("Perfil/Index")]
        public IActionResult Index()
        {
            ViewBag.Usuarios = Getstring;
            ViewBag.Posts = PostModel.LerTodosPost();
            /* return LocalRedirect("~/Perfil/Index"); 
            return View();
    } */

        [Route("Excluir/{Id_post}")]
    public IActionResult Excluir(int Id_post)
    {
        PostModel.Deletar(Id_post);
        ViewBag.Posts = PostModel.LerTodosPost();
        return LocalRedirect("~/Perfil/Index");
    }
}
}