using System;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int maior = int.Parse(valores[0]);

            for (int i = 0; i < 2; i++)
            {
                if(int.Parse(valores[i + 1]) > maior)
                {
                    maior = int.Parse(valores[i + 1]);
                }
            }

            Console.WriteLine($"{maior} eh o maior");
        }
    }
}
