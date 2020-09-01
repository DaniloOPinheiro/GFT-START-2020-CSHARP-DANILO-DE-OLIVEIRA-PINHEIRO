using System;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var contaCC = new ContaCorrente
            {
                Numero = 123,
                Titulo = "PessoaJ",
                Saldo = 100.0
            };

            var cc = new ContaCorrente();
            Console.WriteLine("Conta Corrente:  " + ContaCorrente.totalC);
            Console.ReadKey();
            
            var contaCP = new ContaPoupanca
            {
                Numero = 987,
                Titulo = "PessoaF",
                Saldo = 100.0
            };

            var cp = new ContaPoupanca();
            Console.WriteLine("Conta Corrente:  " + ContaPoupanca.totalP);
            Console.ReadKey();
            
        }
    }

    public abstract class Conta
    {
        public int Numero { get; set; }
        public string Titulo { get; set; }
        public double Saldo { protected get; set; }

        public abstract double Rendimento(double valor, double saldo);
    }

    class ContaCorrente : Conta
    {
        public static int totalC = 0;
        public ContaCorrente()
        {
            totalC++;
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

    class ContaPoupanca : Conta
    {
        public static int totalP = 0;
        public ContaPoupanca()
        {
            totalP++;
        }
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