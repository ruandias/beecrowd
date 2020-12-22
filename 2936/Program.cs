using System;

namespace _2936
{
    class Program
    {
        static void Main()
        {
            int Curupira = 300 * Int32.Parse(Console.ReadLine());
            int Boitatá = 1500 * Int32.Parse(Console.ReadLine());
            int Boto = 600 * Int32.Parse(Console.ReadLine());
            int Mapinguari = 1000 * Int32.Parse(Console.ReadLine());
            int Iara = 150 * Int32.Parse(Console.ReadLine());
            int Chica = 225;
            int total = Curupira + Boitatá + Boto + Mapinguari + Iara + Chica;
            Console.WriteLine(total);
        }
    }
}