using System;

namespace _1117
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            double media = 0, soma = 0;
            do
            {
                double nota = double.Parse(Console.ReadLine());
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    count++;
                    soma += nota;
                }
            } while (count < 2);

            media = soma / count;

            Console.WriteLine("media = " + (media).ToString("N2"));
        }
    }
}
