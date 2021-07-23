using System;

namespace _1064
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeNumeros = 0;
            int positivos = 0;
            double numerosPositiovs = 0;
            double media = 0;


            do
            {
                double numero = double.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    if (numero > 0)
                    {
                        positivos++;
                        numerosPositiovs += numero;
                    }
                    quantidadeNumeros++;
                }
            } while (quantidadeNumeros < 6);

            media = numerosPositiovs / positivos;

            Console.WriteLine($"{positivos} valores positivos");
            Console.WriteLine($"{media:N1}");
        }
    }
}
