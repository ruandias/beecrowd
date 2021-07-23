using System;

namespace _1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeNumeros = 0;
            int positivos = 0;

            do 
            {
                double numero = double.Parse(Console.ReadLine());

                if(numero != 0)
                {
                    if(numero > 0)
                    {
                        positivos++;
                    }
                    quantidadeNumeros++;
                }
            } while(quantidadeNumeros < 6);

            Console.WriteLine($"{positivos} valores positivos");
        }
    }
}
