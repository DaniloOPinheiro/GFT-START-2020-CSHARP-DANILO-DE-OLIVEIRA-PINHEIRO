using System;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Danilo";
            p.Endereço = "Embu-guaçu";
            p.Telefone = "(11)9876-5432";
            

            Console.WriteLine($"Nome : {p.Nome}, Endereço : {p.Endereço}, Telefone : {p.Telefone}");
        }

        public class Pessoa
        {
            public string Nome { get; set; }
            public string Endereço { get; set; }
            public string Telefone { get; set; }
        }
    }
}
