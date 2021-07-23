using System;

namespace _1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int impares = 0;

            while(impares < 6)
            {
                if(!(x % 2 == 0))
                {
                    Console.WriteLine(x);
                    impares++;
                }
                x++;
            }
        }
    }
}
