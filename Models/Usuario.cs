using System;
using System.Collections.Generic;
using System.IO;
using InstaDevFinal.Interfaces;

namespace InstaDevFinal.Models
{
    public class Usuario : InstaDevBase, IUsuario
    {
        private string Nome { get; set; }

        private string Username { get; set; }
        
        private string imagem { get; set; }

        private string texto_post { get; set; }

        private int Id_post { get; set; }

        public const string CAMINHO = "Database/post";

        public Usuario()
        {
            CriarPastaEArquivo(CAMINHO);
        }

        private string PrepararLinha(Usuario j)
        {
            return $"{j.imagem};{j.texto_post};{j.Id_post}";
        }
        public void Criar(Usuario j)
        {
            string[] linha = { PrepararLinha(j) };
            File.AppendAllLines(CAMINHO, linha);

        }

        public List<string> LerTodosPost()
        {
            List<string> posts = new List<string>();
            string[] linhas = File.ReadAllLines(CAMINHO);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Usuario usuario_dados_post = new Usuario();

                usuario_dados_post.imagem = linha[0];
                usuario_dados_post.texto_post = linha[1];
                usuario_dados_post.Id_post = Int32.Parse(linha[2]);

                posts.Add(usuario_dados_post.ToString());
            }
            return posts;
        }
        public List<Usuario> LerTodosUsuarios(int Id_usuario)
        {
            List<Usuario> usuarios = new List<Usuario>();
            string[] linhas_usuario = File.ReadAllLines(CAMINHO);

            foreach (var item in linhas_usuario)
            {
                string[] linha = item.Split(";");
                if (linha[0] == Id_usuario.ToString())
                {    
                Usuario usuario_dados = new Usuario();
                usuario_dados.Nome = linha[1];
                usuario_dados.Username = linha[2];
                
                usuarios.Add(usuario_dados);
                }

            }
            return usuarios;
        }

        public void Deletar(int Id_post)
        {
            List<string> linhas_do_csv = LerTodasLinhasCSV(CAMINHO);
            linhas_do_csv.RemoveAll(item => item.Split(";")[0] == Id_post.ToString());
            ReescreverCSV(CAMINHO, linhas_do_csv);
        }
    }
}