using System.Collections.Generic;
using System.IO;

namespace InstaDevFinal.Models
{
    public class Post : InstaDevBase
    {
        public string image { get; set;}
        public string textopost { get; set;}
        public string idpost { get; set;}
        public const string CAMINHO = "DataBase/feed";
         public Post (){
            CriarPastaEArquivo(CAMINHO);
        }
        public string PrepararLinha (Post P){
            return "{P.image};{P.textopost};{P.idpost}";
        }
        public void PostarPost (Post P){
            string[] linha = {PrepararLinha(P)};
            File.AppendAllLines(CAMINHO, linha);
        }
        public List<Post> LerTodos (){
            List<Post> posts = new List<Post>();
            string[] linhas = File.ReadAllLines(CAMINHO);
            foreach (var item in linhas)
            {
                string[] linha = item.Split (";");
                Post novoPost = new Post();
                novoPost.image = linha[0];

                novoPost.textopost = linha[1];
                novoPost.idpost = linha[2];
            }
            return posts;
        }

    }
}