using System.Collections.Generic;
using InstaDevFinal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InstaDevFinal.Controllers
{
    [Route("Login")]
    public class LoginController : Controller
    {

        [TempData]
        public string Mensagem { get; set; }

        Usuario UsuarioModel = new Usuario();

        public IActionResult Index()
        {

            return View();
        }

        /* [Route("Logar")]
        public IActionResult Logar(IFormCollection form)
        {
            List<string> UsuarioesCSV = UsuarioModel.LerTodasLinhasCSV("Database/Usuario.csv");

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
 */
        /* [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Nome Usuario");
            return LocalRedirect("~/Login");
        } */
    }
}