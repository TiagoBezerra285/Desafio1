using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um Número Inteiro");
            int numero = int.Parse(Console.ReadLine());
           

            for (int i = 1; i <= numero; i++)
            {
                int numDivisores = 0;
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % j == 0)
                        {
                            numDivisores++;
                        }
                    }
                    if (numDivisores == 2)
                        Console.WriteLine("Primo" + i);

                }



            }
        }      
    }
}
