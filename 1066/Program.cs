using System;

namespace _1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int pares = 0;
            int impares = 0;
            int positivos = 0;
            int negativos = 0;

            for (int i = 0; i < 5; i++)
            {
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    pares++;

                    if (numero > 0)
                    {
                        positivos++;
                    }
                    else if(numero < 0)
                    {
                        negativos++;
                    }
                }
                else
                {
                    impares++;

                    if (numero > 0)
                    {
                        positivos++;
                    }
                    else
                    {
                        negativos++;
                    }
                }
            }

            Console.WriteLine($"{pares} valor(es) par(es)");
            Console.WriteLine($"{impares} valor(es) impar(es)");
            Console.WriteLine($"{positivos} valor(es) positivo(s)");
            Console.WriteLine($"{negativos} valor(es) negativo(s)");
        }
    }
}
