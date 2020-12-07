using System;
using System.Globalization;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159;
            double raio = double.Parse(Console.ReadLine());
            double area = PI * Math.Pow(raio, 2);

            Console.WriteLine("A={0}", string.Format("{0:0.0000}", area));
        }
    }
}
