using System;

namespace Exercicio_01
{
    public static class Impares
    {
        public static void SetImpar(int a, int b)
        {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.WriteLine("Introduza um numero : \t");
                a = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Introduza outro numero : \t");
                b = Int32.Parse(Console.ReadLine());

                Console.WriteLine("---------------------------");

                Console.Write("Essa é a sequência de números impares :");

                for (int i = ++a; i < b; i++)
                {
                    if( i % 2 != 0 )
                        Console.Write(" " + i);
                }
                Console.ReadLine();
        }

    }
}