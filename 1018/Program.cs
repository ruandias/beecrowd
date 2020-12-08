using System;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota100 = 0;
            int nota50 = 0;
            int nota20 = 0;
            int nota10 = 0;
            int nota5 = 0;
            int nota2 = 0;
            int nota1 = 0;

            int valor = int.Parse(Console.ReadLine());
            int total = valor;

            while (total > 0 && total < 1000000)
            {
                if(total >= 100)
                {
                    total -= 100;
                    nota100++;
                }
                else if(total >= 50)
                {
                    total -= 50;
                    nota50++;
                }
                else if(total >= 20)
                {
                    total -= 20;
                    nota20++;
                }
                else if(total >= 10)
                {
                    total -= 10;
                    nota10++;
                }
                else if(total >= 5)
                {
                    total -= 5;
                    nota5++;
                }
                else if(total >= 2)
                {
                    total -= 2;
                    nota2++;
                }
                else if(total >= 1)
                {
                    total -= 1;
                    nota1++;
                }
            }

            Console.WriteLine("{0}", valor);
            Console.WriteLine("{0} nota(s) de R$ 100,00", nota100);
            Console.WriteLine("{0} nota(s) de R$ 50,00", nota50);
            Console.WriteLine("{0} nota(s) de R$ 20,00", nota20);
            Console.WriteLine("{0} nota(s) de R$ 10,00", nota10);
            Console.WriteLine("{0} nota(s) de R$ 5,00", nota5);
            Console.WriteLine("{0} nota(s) de R$ 2,00", nota2);
            Console.WriteLine("{0} nota(s) de R$ 1,00", nota1);
        }
    }
}
