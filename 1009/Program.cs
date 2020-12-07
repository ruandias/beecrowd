using System;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            const double PORCENTAGEM = 0.15;
            double salario = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());

            double total = salario + PORCENTAGEM * vendas;
            
            Console.WriteLine("TOTAL = R$ {0}", string.Format("{0:0.00}", total));
        }
    }
}
