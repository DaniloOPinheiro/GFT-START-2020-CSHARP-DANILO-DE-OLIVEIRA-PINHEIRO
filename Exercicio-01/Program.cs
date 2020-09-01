using System;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número :");
            short a = short.Parse(Console.ReadLine());

            string impares = "";

            for (int i = 0; i <=a; i++)
            {
                if (i % 3 == 0)
                {
                    i++;
                    if (i<a)
                        impares += i + ",";
                    else
                        impares += i ;
                }

            }
            // Console.WriteLine("soma dos pares : " +  res);
            Console.WriteLine("numeros impares : " + impares);
            Console.ReadLine();


        }
    }
}
