using System;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int velocidadeMedia = int.Parse(Console.ReadLine());

            int distancia = velocidadeMedia * tempo;

            double gasolinaNecessaria = distancia / 12.0;

            Console.WriteLine("{0}", string.Format("{0:0.000}", gasolinaNecessaria));
        }
    }
}
