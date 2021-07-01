using System.Collections.Generic;
using InstaDevFinal.Models;

namespace InstaDevFinal.Interfaces
{
    public interface IUsuario
    {
         List<string> LerTodosPost();
         List<Usuario> LerTodosUsuarios();

         void Deletar(int Id_post);
    }
}