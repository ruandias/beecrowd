using System;

namespace _1036
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);

            double delta = Math.Pow(b, 2) - 4 * a * c;

            double raiz = Math.Sqrt(delta);

            if (raiz < 0 || a == 0 || delta < 0)
                Console.WriteLine("Impossivel calcular");
            else
            {
                double r1 = (-b + raiz) / (2 * a);
                double r2 = (-b - raiz) / (2 * a);
                Console.WriteLine("R1 = {0}", String.Format("{0:0.00000}", r1));
                Console.WriteLine("R2 = {0}", String.Format("{0:0.00000}", r2));
            }

        }
    }
}
