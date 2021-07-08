using InstaDevFinal.Models;
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

        // public IActionResult Postar()
        // {
        //     Jogador novoJogador = new Jogador();
        //     novoJogador.Id_Jogador = Int32.Parse(form["IdJogador"]);
        //     novoJogador.Id_Equipe = Int32.Parse(form["IdEquipe"]);
        //     novoJogador.Nome = form["Nome"];
        //     novoJogador.Email = form["Email"];
        //     novoJogador.Senha = form["Senha"];

        //     JogadorModel.Criar(novoJogador);
        //     ViewBag.Jogadores = JogadorModel.LerTodos();

        //     return LocalRedirect("~/Jogador/Index");
        // }

    }
}