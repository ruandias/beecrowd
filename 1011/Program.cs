using System;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            double raio = double.Parse(Console.ReadLine());

            double volume = (4 / 3.0) * PI * Math.Pow(raio, 3);

            
            Console.WriteLine("VOLUME = {0}", string.Format("{0:0.000}", volume));
        }
    }
}
