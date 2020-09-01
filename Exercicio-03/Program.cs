using System;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // var primeiraConta = new Conta
            // {
            //     Numero = 123,
            //     Titulo = "Pessoa",
            //     Saldo = 100.0
            // };
            // Console.WriteLine(primeiraConta.Numero + primeiraConta.Titulo);
            // Console.ReadLine();
        }
    }

    public abstract class Conta
    {
        public int Numero { get; set; }
        public string Titulo { get; set; }
        public double Saldo { protected get; set; }

        public abstract double Rendiemnto(double valor, double saldo);
    }

    public class ContaCorrente : Conta
    {
        public override double Rendiemnto(double valor, double saldo)
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
        public override double Rendiemnto(double valor, double saldo)
        {
            if (saldo  >= valor)
            {
                saldo -= (valor * 0.5);
            }
            return saldo;
        }
    }
}