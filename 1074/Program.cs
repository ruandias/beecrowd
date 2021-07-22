using System;

namespace _1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDeNumeros = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidadeDeNumeros; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if(n == 0)
                {
                    Console.WriteLine("NULL");
                }
                else if(n % 2 == 0)
                {
                    if(n > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else 
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                }
                else 
                {
                    if(n > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else 
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }
    }
}
