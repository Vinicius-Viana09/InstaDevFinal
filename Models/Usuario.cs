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
        public string Email { get; set; }

        public string Senha { get; set; }

        public string Foto { get; set; }

        public string Id_usuario { get; set; }

        public const string CAMINHO2 = "Database/post.csv";

        public const string CAMINHO = "Database/usuarios.csv";

        public Usuario()
        {
            CriarPastaEArquivo(CAMINHO);
        }

        private string PrepararLinha(Usuario u)
        {
            return $"{u.Id_usuario};{u.Nome};{u.Username};{u.Email};{u.Senha}";
        }
        public void Criar(Usuario u)
        {
            string[] linha = { PrepararLinha(u)};
            File.AppendAllLines(CAMINHO, linha);
        }

        public void AlterarDados(Usuario u)
        {
            List<string> linhas_do_csv = LerTodasLinhasCSV(CAMINHO);
            linhas_do_csv.RemoveAll(item => item.Split(";")[0] == u.Id_usuario.ToString());
            linhas_do_csv.Add(PrepararLinha(u));
            ReescreverCSV(CAMINHO, linhas_do_csv);
        }

        public void DeletarConta(int Id)
        {
            List<string> linhas = LerTodasLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == Id_usuario.ToString());
            ReescreverCSV(CAMINHO, linhas);
        }
        
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