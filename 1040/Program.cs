using System;
using System.Globalization;

namespace _1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double n4 = double.Parse(valores[3], CultureInfo.InvariantCulture);

            double media = (2 * n1 + 3 * n2 + 4 * n3 + n4) / 10.0;

            Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");

            if (media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else
            {
                Console.WriteLine("Aluno em exame.");

                double notaExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine($"Nota do exame: {notaExame.ToString("F1", CultureInfo.InvariantCulture)}");

                double mediaFinal = (media + notaExame) / 2.0;

                if (mediaFinal >= 5.0)
                    Console.WriteLine("Aluno aprovado.");
                else
                    Console.WriteLine("Aluno reprovado.");

                Console.WriteLine($"Media final: {mediaFinal.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}