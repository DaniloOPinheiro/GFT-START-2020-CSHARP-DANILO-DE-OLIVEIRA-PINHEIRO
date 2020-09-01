using System;

namespace Exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            

            ContaPoupanca cp = new ContaPoupanca();
        }

        public abstract class Conta
        {
            int numero;
            string titulo;
            double saldo;

           public abstract void Rendiemnto();

        }

        public class ContaCorrente : Conta
        {
            public override void Rendiemnto()
            {
                saldo * 0.03;
            }
        }

        public class ContaPoupanca : Conta
        {
            public override void Rendiemnto()
            {
                saldo * 0.05;
            }
        }
    }
}
