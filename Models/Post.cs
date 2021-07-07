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
        public const string CAMINHO = "Database/post.csv";

        public Post(){
            CriarPastaEArquivo(CAMINHO);
        }

        private string PrepararLinha(Post j)
        {
            return $"{j.imagem};{j.texto_post};{j.Id_post}";
        }
        public void Criar(Post k)
        {
            string[] linha2 = { PrepararLinha(k) };
            File.AppendAllLines(CAMINHO, linha2);
        }

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