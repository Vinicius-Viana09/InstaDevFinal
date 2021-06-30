using System.Collections.Generic;
using InstaDevFinal.Models;

namespace InstaDevFinal.Interfaces
{
    public interface IUsuario
    {
         List<string> LerTodos();

         void Deletar(int Id_post);
    }
}