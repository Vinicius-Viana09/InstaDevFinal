using System.Collections.Generic;
using InstaDevFinal.Models;

namespace InstaDevFinal.Interfaces
{
    public interface IUsuario
    {
        void Criar(Usuario u);
        void AlterarDados(Usuario u);
        void DeletarConta(int Id);
        List<Usuario> LerUsuarios();
    }
}