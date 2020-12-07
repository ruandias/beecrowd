using System;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linha1 = Console.ReadLine().Split(' ');
            string[] linha2 = Console.ReadLine().Split(' ');

            double x1 = double.Parse(linha1[0]);
            double y1 = double.Parse(linha1[1]);

            double x2 = double.Parse(linha2[0]);
            double y2 = double.Parse(linha2[1]);

            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("{0}", string.Format("{0:0.0000}", distancia));
        }
    }
}
