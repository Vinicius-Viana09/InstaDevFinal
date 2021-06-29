using InstaDevFinal.Interfaces;

namespace InstaDevFinal.Models
{
    public class Cadastro : InstaDevBase, ICadastro
    {
        public int Email { get; set; }
        public string NomeCompleto { get; set; }
        public int NomeUsuario { get; set; }
        public string Senha { get; set; }

        public void Criar(Cadastro c)
        {
            throw new System.NotImplementedException();
        }
    }
}