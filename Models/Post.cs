using System.Collections.Generic;
using System.IO;

namespace InstaDevFinal.Models
{
    public class Post : InstaDevBase
    {
        public string imagem { get; set; }
        public string texto_post { get; set; }
        public string Id_post { get; set; }
        public string Username { get; set; }
        public const string CAMINHO = "Database/feed.csv";
        
        public Post (){
            CriarPastaEArquivo(CAMINHO);
        }

        public string PrepararLinha (Post P){
            return $"{P.imagem};{P.texto_post};{P.Id_post}";
        }

        public void PostarPost (Post P){
            string[] linha = {PrepararLinha(P)};
            File.AppendAllLines(CAMINHO, linha);
        }

        /* public List<Post> LerTodos (){
            List<Post> posts = new List<Post>();
            string[] linhas = File.ReadAllLines(CAMINHO);
            foreach (var item in linhas)
            {
                string[] linha = item.Split (";");
                Post novoPost = new Post();
                novoPost.imagem = linha[0];

                novoPost.texto_post = linha[1];
                novoPost.Id_post = linha[2];
            }
            return posts;
        } */

        public List<Post> LerTodosPost()
        {
            List<Post> posts = new List<Post>();
            string[] linhas = File.ReadAllLines(CAMINHO);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Post post_dados = new Post();

                post_dados.imagem = linha[0];
                post_dados.texto_post = linha[1];
                post_dados.Id_post = linha[2];

                posts.Add(post_dados);
            }
            return posts;
        }
        public void Deletar(int Id_post)
        {
            List<string> linhas_do_csv = LerTodasLinhasCSV(CAMINHO);
            linhas_do_csv.RemoveAll(item => item.Split(";")[0] == Id_post.ToString());
            ReescreverCSV(CAMINHO, linhas_do_csv);
        }

        public List<Post> PostPerfil(string username){

            List<Post> Todos_Posts = LerTodosPost();

            List<Post> Usuario_Posts = new List<Post>();

            foreach (var item in Todos_Posts)
            {
                if (item.Username == username)
                {
                    Usuario_Posts.Add(item);
                }
            }

          return Usuario_Posts;
        }

    }
}