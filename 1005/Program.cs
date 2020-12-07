using System;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
        {

            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());

            double media = (n1 * 3.5 + n2 * 7.5) / 11;

            Console.WriteLine("MEDIA = {0}", media.ToString("N5"));
        }
    }
}
