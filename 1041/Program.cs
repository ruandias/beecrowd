using System;

namespace _1041
{
    class Program
    {
        public struct Ponto
        {
            public float X;
            public float Y;
        }
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            Ponto ponto = new Ponto()
            {
                X = float.Parse(valores[0]),
                Y = float.Parse(valores[1])
            };

            if (ponto.X == 0 && ponto.Y == 0)
                Console.WriteLine("Origem");
            else if (ponto.X > 0 && ponto.Y > 0)
                Console.WriteLine("Q1");
            else if (ponto.X < 0 && ponto.Y > 0)
                Console.WriteLine("Q2");
            else if (ponto.X < 0 && ponto.Y < 0)
                Console.WriteLine("Q3");
            else if (ponto.X > 0 && ponto.Y < 0)
                Console.WriteLine("Q4");
            else if (ponto.X == 0 && ponto.Y != 0)
                Console.WriteLine("Eixo Y");
            else if (ponto.X != 0 && ponto.Y == 0)
                Console.WriteLine("Eixo X");
        }
    }
}
