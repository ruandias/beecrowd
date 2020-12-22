using System;

namespace _1143
{
    class Program
    {
        static void Main()
        {
            int N = -1;
            do
            {
                N = Int32.Parse(Console.ReadLine());
            } while (N < 1 || N > 1000);
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{Math.Pow(i, 1)} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
    }
}
