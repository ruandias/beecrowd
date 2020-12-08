using System;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos = int.Parse(Console.ReadLine());
            int total = segundos;
            int horas = 0, minutos = 0;

            while(total > 0)
            {
                if(total >= 3600)
                {
                    total -= 3600;
                    horas++;
                }
                else if(total >= 60)
                {
                    total -= 60;
                    minutos++;
                }
                else
                {
                    segundos = total;
                    total = 0;
                }
            }
            Console.WriteLine("{0}:{1}:{2}" , horas, minutos, segundos);
        }
    }
}
