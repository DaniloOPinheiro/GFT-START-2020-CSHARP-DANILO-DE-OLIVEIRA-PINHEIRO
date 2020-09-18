using System;

namespace Exercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas.Pessoa pp = new Pessoas.Pessoa();
            Console.WriteLine("Digite seu nome ?");
            pp.Nome = string.Format(Console.ReadLine());

            Console.WriteLine("Digite seu endereço ?");
            pp.Endereço = string.Format(Console.ReadLine());

            Console.WriteLine("Digite seu telefone ?");
            pp.Telefone = (Console.ReadLine());

            Console.WriteLine(
            $"Nome : {pp.Nome},Endereço : {pp.Endereço},Telefone : {string.Format(@"{(00):0000-0000}, pp.Telefone}}"));
        }

    }
}
