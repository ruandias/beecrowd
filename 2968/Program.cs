using System;

namespace _2968
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int voltas = int.Parse(entrada[0]);

            int placas = int.Parse(entrada[1]);

            int totalPercurso = voltas * placas;

            const decimal PORCENTO = 0.1M;
            decimal passo = PORCENTO;


            while (passo < 1)
            {
                decimal percorrido = totalPercurso * passo;
                
                Console.Write("{0} ", (int)Math.Ceiling(percorrido));
                
                passo += PORCENTO;
            }
        }
    }
}
