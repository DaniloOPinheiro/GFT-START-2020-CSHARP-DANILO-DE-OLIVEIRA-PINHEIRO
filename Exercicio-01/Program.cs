using System;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza um numero");
            var a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduza outro numero");
            var b = Int32.Parse(Console.ReadLine());

            if (b < a)
            {
                var c = a;
                a = b;
                b = c;
            }

            for (int i = ++a; i < b; i++)
            {
                 if( i % 2 != 0 )
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
