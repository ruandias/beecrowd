using System;

namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total = 0;

            switch(codigo)
            {
                case 1:
                    total = quantidade * 4;
                    break;
                case 2:
                    total = quantidade * 4.50;
                    break;
                case 3:
                    total = quantidade * 5;
                    break;
                case 4:
                    total = quantidade * 2;
                    break;
                case 5:
                    total = quantidade * 1.5;
                    break;
            }

            Console.WriteLine("Total: R$ {0}", total.ToString("N2"));

        }
    }
}
