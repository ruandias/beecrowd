using System;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linha1 = Console.ReadLine().Split(' ');
            string[] linha2 = Console.ReadLine().Split(' ');

            int peca01 = int.Parse(linha1[1]);
            double valor01 = double.Parse(linha1[2]);

            int peca02 = int.Parse(linha2[1]);
            double valor02 = double.Parse(linha2[2]);

            double total = peca01 * valor01 + peca02 * valor02;

            Console.WriteLine("VALOR A PAGAR: R$ {0}", string.Format("{0:0.00}", total));
        }
    }
}
