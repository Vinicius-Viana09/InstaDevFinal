using System.Collections.Generic;
using InstaDevFinal.Models;

namespace InstaDevFinal.Interfaces
{
    public interface IUsuario
    {
<<<<<<< HEAD
        void Criar(Usuario u);
        void AlterarDados(Usuario u);
        void DeletarConta(int Id);
        List<Usuario> LerUsuarios();
=======
         /* List<string> LerTodosPost(); */
         List<Usuario> LerTodosUsuarios(/* int Id_usuario */);

         /* void Deletar(int Id_post); */
>>>>>>> origin/Perfil
    }
}