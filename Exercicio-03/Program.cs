using System;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // var contaPessoa = new ContaCorrente
            // {
            //     Numero = 123,
            //     Titulo = "Pessoa",
            //     Saldo = 100.0
            // };

            var cc = new ContaCorrente();

            Console.WriteLine(cc.total);
            Console.ReadLine();
        }
    }

    public abstract class Conta
    {
        public int Numero { get; set; }
        public string Titulo { get; set; }
        public double Saldo { protected get; set; }

        public abstract double Rendimento(double valor, double saldo);
    }

    public class ContaCorrente : Conta
    {
        public static int total = 0;
        public ContaCorrente()
        {
            total++;
        }
        public override double Rendimento(double valor, double saldo)
        {
            if (saldo  >= valor)
            {
                saldo -= (valor * 0.3);
            }
            return saldo;
        }
    }

    public class ContaPoupanca : Conta
    {
        public override double Rendimento(double valor, double saldo)
        {
            if (saldo  >= valor)
            {
                saldo -= (valor * 0.5);
            }
            return saldo;
        }
    }
}