using System;

namespace _1040
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            var notas = new double[4];
            int index = 0;

            foreach(var valor in valores)
            {
                notas[index] = double.Parse(valor);
                index++;
            }

            var media = (2*notas[0] + 3*notas[1] + 4*notas[2] + notas[3]) / 10;

            Console.WriteLine($"Media: {media:N1}");
            if(media > 7.0)
                Console.WriteLine("Aluno aprovado.");
            else if(media < 5.0)
                Console.WriteLine("Aluno reprovado.");
            else 
            {
                Console.WriteLine("Aluno em exame.");
                Console.Write("Nota do exame: ");
                var nota = double.Parse(Console.ReadLine());
                var mediaFinal = (media + nota) / 2;
                if(media >= 5.0)
                    Console.WriteLine("Aluno aprovado.");
                else 
                    Console.WriteLine("Aluno reprovado.");
                Console.WriteLine($"Media final: {mediaFinal:N1}");
            }
        }
    }
}
