using System;

namespace _1044
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if(A > B)
            {
                if(A % B == 0)
                    Console.WriteLine("Sao Multiplos");
                else 
                    Console.WriteLine("Nao sao Multiplos");
            }
            else 
            {
                if(B % A == 0)
                    Console.WriteLine("Sao Multiplos");
                else 
                    Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
