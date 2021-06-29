using System.Collections.Generic;
using InstaDevFinal.Interfaces;

namespace InstaDevFinal.Models
{
    public class Usuario : InstaDevBase, IUsuario
    {
        private string imagem { get; set; }

        private string texto_post { get; set; }

        public const string CAMINHO = "Database/post";
        
        

        public void Alterar(Post p)
        {
            throw new System.NotImplementedException();
        }

        public List<Usuario> LerTodos()
        {
           List<string> linhas = LerTodasLinhasCSV(CAMINHO);
        }
    }
}