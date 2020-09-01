using System;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 13;
            int res = 0;
            int i;
            string npares="";
            for (i = 0; i <=a; i++)
            {
                if (i % 2 == 0)
                {
                    res = res + i;
                    if (i<a)
                        npares += i + ",";
                    else
                        npares += i ;
                }

               
            }
            Console.WriteLine("soma dos pares : " +  res);
            Console.WriteLine("numeros pares : " + npares);
            Console.ReadLine();


        }
    }
}
