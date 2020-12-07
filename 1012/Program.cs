using System;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            double A = double.Parse(valores[0]);
            double B = double.Parse(valores[1]);
            double C = double.Parse(valores[2]);
            const double PI = 3.14159;

            double areaTriangulo = (A * C) / 2.0;
            double areaCirculo = PI * Math.Pow(C, 2);
            double areaTrapezio = ((A + B) * C) / 2.0;
            double areaQuadrado = Math.Pow(B, 2);
            double areaRetangulo = A * B;

            Console.WriteLine("TRIANGULO: {0}", string.Format("{0:0.000}", areaTriangulo));
            Console.WriteLine("CIRCULO: {0}", string.Format("{0:0.000}", areaCirculo));
            Console.WriteLine("TRAPEZIO: {0}", string.Format("{0:0.000}", areaTrapezio));
            Console.WriteLine("QUADRADO: {0}", string.Format("{0:0.000}", areaQuadrado));
            Console.WriteLine("RETANGULO: {0}", string.Format("{0:0.000}", areaRetangulo));
        }
    }
}
