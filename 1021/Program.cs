using System;

namespace _1021
{
    class Program
    {
        static void Main(string[] args)
        {
            int notas100 = 0, notas50 = 0, notas20 = 0, notas10 = 0, notas5 = 0, notas2 = 0;
            int moedas1 = 0, moedas050 = 0, moedas025 = 0, moedas010 = 0, moedas05 = 0, moedas01 = 0;
            decimal valor = decimal.Parse(Console.ReadLine());

            while (valor > 0)
            {
                if (valor >= 100)
                {
                    valor -= 100;
                    notas100++;
                }
                else if (valor >= 50)
                {
                    valor -= 50;
                    notas50++;
                }
                else if (valor >= 20)
                {
                    valor -= 20;
                    notas20++;
                }
                else if (valor >= 10)
                {
                    valor -= 10;
                    notas10++;
                }
                else if (valor >= 5)
                {
                    valor -= 5;
                    notas5++;
                }
                else if (valor >= 2)
                {
                    valor -= 2;
                    notas2++;
                }
                else if (valor >= 1)
                {
                    valor -= 1;
                    moedas1++;
                }
                else if (valor >= (decimal)0.5)
                {
                    valor -= (decimal)0.5;
                    moedas050++;
                }
                else if (valor >= (decimal)0.25)
                {
                    valor -= (decimal)0.25;
                    moedas025++;
                }
                else if (valor >= (decimal)0.10)
                {
                    valor -= (decimal)0.10;
                    moedas010++;
                }
                else if (valor >= (decimal)0.05)
                {
                    valor -= (decimal)0.05;
                    moedas05++;
                }
                else if (valor >= (decimal)0.01)
                {
                    valor -= (decimal)0.01;
                    moedas01++;
                }
                else
                {
                    valor = 0;
                }
            }

            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", notas100);
            Console.WriteLine("{0} nota(s) de R$ 50.00", notas50);
            Console.WriteLine("{0} nota(s) de R$ 20.00", notas20);
            Console.WriteLine("{0} nota(s) de R$ 10.00", notas10);
            Console.WriteLine("{0} nota(s) de R$ 5.00", notas5);
            Console.WriteLine("{0} nota(s) de R$ 2.00", notas2);
            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", moedas1);
            Console.WriteLine("{0} moeda(s) de R$ 0.50", moedas050);
            Console.WriteLine("{0} moeda(s) de R$ 0.25", moedas025);
            Console.WriteLine("{0} moeda(s) de R$ 0.10", moedas010);
            Console.WriteLine("{0} moeda(s) de R$ 0.05", moedas05);
            Console.WriteLine("{0} moeda(s) de R$ 0.01", moedas01);
        }
    }
}
