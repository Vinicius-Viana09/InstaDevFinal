using System.Collections.Generic;
using System.IO;
using InstaDevFinal.Interfaces;

namespace InstaDevFinal.Models
{
    public class Usuario : InstaDevBase, IUsuario
    {
        public string Email { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeUsuario { get; set; }
        public string Senha { get; set; }
        public string Imagem { get; set; }

        public string IdUsuario { get; set; }

        public const string CAMINHO = "Database/Usuario.csv";

        public Usuario()
        {
            CriarPastaEArquivo(CAMINHO);
        }

        private string PrepararLinha(Usuario u)
        {
            return $"{u.IdUsuario};{u.NomeCompleto};{u.NomeUsuario};{u.Email};{u.Senha}";
        }

        public List<Usuario> LerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string[] linhas = File.ReadAllLines(CAMINHO);

            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");

                Usuario novoUsuario = new Usuario();

                novoUsuario.IdUsuario = linha[0];
                novoUsuario.NomeCompleto = linha[1];
                novoUsuario.NomeUsuario = linha[2];
                novoUsuario.Email = linha[3];
                novoUsuario.Senha = linha[4];

                usuarios.Add(novoUsuario);
            }
            return usuarios;
        }

        internal void Create(Usuario novaUsuario)
        {
            throw new System.NotImplementedException();
        }

        public void Criar(Usuario u)
        {
            string[] linha = { PrepararLinha(u)};
            File.AppendAllLines(CAMINHO, linha);
        }

        public void AlterarDados(Usuario u)
        {
            List<string> linhas_do_csv = LerTodasLinhasCSV(CAMINHO);
            linhas_do_csv.RemoveAll(item => item.Split(";")[0] == u.IdUsuario.ToString());
            linhas_do_csv.Add(PrepararLinha(u));
            ReescreverCSV(CAMINHO, linhas_do_csv);
        }

        public void DeletarConta(int Id)
        {
            List<string> linhas = LerTodasLinhasCSV(CAMINHO);
            linhas.RemoveAll(x => x.Split(";")[0] == IdUsuario.ToString());
            ReescreverCSV(CAMINHO, linhas);
        }
    }
}