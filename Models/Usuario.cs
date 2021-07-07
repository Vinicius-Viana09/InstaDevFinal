using System;
using System.Collections.Generic;
using System.IO;
using InstaDevFinal.Interfaces;

namespace InstaDevFinal.Models
{
    public class Usuario : InstaDevBase, IUsuario
    {
        public string Nome { get; set; }

        public string Username { get; set; }

        public string Senha { get; set; }

        public string Foto { get; set; }

        public string Id_usuario { get; set; }

        public const string CAMINHO = "Database/post.csv";

        public const string CAMINHO2 = "Database/usuarios.csv";

        public Usuario()
        {
            CriarPastaEArquivo(CAMINHO);

        }

        /* private string PrepararLinha(Post j)
        {
            return $"{j.imagem};{j.texto_post};{j.Id_post}";
        } */
        private string PrepararLinha2(Usuario j)
        {
            return $"{j.Nome};{j.Username};{j.Id_usuario};{j.Senha}";
        }
        public void Criar(Usuario j)
        {
            string[] linha = { PrepararLinha2(j) };
            File.AppendAllLines(CAMINHO2, linha);
        }
        /* public void Criar(Post k)
        {
            string[] linha2 = { PrepararLinha(k) };
            File.AppendAllLines(CAMINHO, linha2);
        } */

        /* public List<string> LerTodosPost()
        {
            List<string> posts = new List<string>();
            string[] linhas = File.ReadAllLines(CAMINHO);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Post post_dados = new Post();

                post_dados.imagem = linha[0];
                post_dados.texto_post = linha[1];
                post_dados.Id_post = linha[2];

                posts.Add(post_dados.ToString());
            }
            return posts;
        } */
        public List<Usuario> LerTodosUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string[] linhas_usuario = File.ReadAllLines(CAMINHO2);

            foreach (var item in linhas_usuario)
            {
                string[] linha = item.Split(";");

                Usuario usuario_dados = new Usuario();
                usuario_dados.Id_usuario = linha[0];   
                usuario_dados.Nome = linha[1];
                usuario_dados.Username = linha[2];
                usuario_dados.Senha = linha[3];
                usuario_dados.Foto = linha[4];

                usuarios.Add(usuario_dados);

            }
            return usuarios;
        }

        /* public void Deletar(int Id_post)
        {
            List<string> linhas_do_csv = LerTodasLinhasCSV(CAMINHO);
            linhas_do_csv.RemoveAll(item => item.Split(";")[0] == Id_post.ToString());
            ReescreverCSV(CAMINHO, linhas_do_csv);
        } */

        public Usuario ULogado(string Username){
            List<Usuario> batata = LerTodosUsuarios();
            Usuario batatinha_usuario = new Usuario();

            foreach (Usuario item in batata)
            {
                if (item.Username == Username)
                {
                    return item;
                }
            }
                return null;
        }
    }
}