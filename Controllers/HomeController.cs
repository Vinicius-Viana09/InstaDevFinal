﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InstaDevFinal.Models;

namespace InstaDevFinal.Controllers
{
    
    public class HomeController : Controller
    {
        Usuario UsuarioModel = new Usuario();
        Post PostModel = new Post();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Usuarios = UsuarioModel.LerTodosUsuarios();
            ViewBag.Posts = PostModel.LerTodosPost();
            return LocalRedirect("~/Perfil/Index");
            /* return View(); */
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
    }
}
