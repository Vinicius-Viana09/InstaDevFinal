using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InstaDevFinal.Models;
using Microsoft.AspNetCore.Http;

namespace InstaDevFinal.Controllers
{
    
    public class HomeController : Controller
    {
         [TempData]
        public string Mensagem { get; set; }

        Usuario UsuarioModel = new Usuario();
        Post PostModel = new Post();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            /* ViewBag.Usuarios = UsuarioModel.LerTodosUsuarios();
            ViewBag.Posts = PostModel.LerTodosPost();
            return LocalRedirect("~/Perfil/Index"); */
            return View(); 
        }

        [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            List<string> UsuarioesCSV = UsuarioModel.LerTodasLinhasCSV("Database/usuarios.csv");

            var logado = UsuarioesCSV.Find(
                x =>
                x.Split(";")[3] == form["Email"] &&
                x.Split(";")[4] == form["Senha"]
            );

            if (logado != null)
            {
                HttpContext.Session.SetString("Username", logado.Split(";")[2
                ]);
                return LocalRedirect("~/Feed");
            }

            Mensagem = "Dados incorretos, tente novamente...";
            return LocalRedirect("~/Login");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Nome Usuario");
            return LocalRedirect("~/Home");
        }
    }
}
