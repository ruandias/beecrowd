using System;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaPercorrida = int.Parse(Console.ReadLine());
            double combustivelGasto = double.Parse(Console.ReadLine());

            double consumoMedio = distanciaPercorrida / combustivelGasto;

            Console.WriteLine("{0} km/l", string.Format("{0:0.000}", consumoMedio)) ;
        }
    }
}
