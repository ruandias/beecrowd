using System;

namespace _1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadePares = int.Parse(Console.ReadLine());

            double divisao = 0;

            for (int i = 0; i < quantidadePares; i++)
            {
                string[] numeros = Console.ReadLine().Split(' ');
                
                int X = int.Parse(numeros[0]);

                int Y = int.Parse(numeros[1]);

                if (Y == 0)
                    Console.WriteLine("divisao impossivel");
                else
                {
                    divisao = (double) X / Y;
                    Console.WriteLine(divisao.ToString("N1"));
                }
            }
        }
    }
}
