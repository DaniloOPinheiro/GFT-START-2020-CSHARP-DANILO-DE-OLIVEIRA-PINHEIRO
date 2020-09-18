namespace Exercicio_02
{
    public class Cadastro
    {
        public Cadastro(string nome, string endereco, string telefone)
        {
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }

    }
}