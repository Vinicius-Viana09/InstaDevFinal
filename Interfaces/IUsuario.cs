using System.Collections.Generic;
using InstaDevFinal.Models;

namespace InstaDevFinal.Interfaces
{
    public interface IUsuario
    {
         List<Usuario> LerTodos();

         void Alterar(Post p);
    }
}