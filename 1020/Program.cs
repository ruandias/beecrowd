using System;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeEmDias = int.Parse(Console.ReadLine());

            int anos = 0, meses = 0, dias = 0;
            
            while(idadeEmDias > 0)
            {
                if(idadeEmDias >= 365)
                {
                    anos++;
                    idadeEmDias -= 365;
                }
                else if(idadeEmDias >= 30)
                {
                    meses++;
                    idadeEmDias -= 30;
                }
                else
                {
                    dias = idadeEmDias;
                    idadeEmDias = 0;
                }
            }

            Console.WriteLine("{0} ano(s)", anos);
            Console.WriteLine("{0} mes(es)", meses);
            Console.WriteLine("{0} dia(s)", dias);
        }
    }
}
