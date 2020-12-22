using System;

namespace _1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Z, quantidade = 0, soma = 0;
            Z = Int32.Parse(Console.ReadLine());

            do
            {
                X = Int32.Parse(Console.ReadLine());
            } while (X <= Z);


            while (soma <= X)
            {
                soma += Z++;
                quantidade++;
            }

            Console.WriteLine(quantidade);
        }
    }
}
