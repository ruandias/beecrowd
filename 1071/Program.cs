using System;

namespace _1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int somatorio = SomaImpares(x, y);
            Console.WriteLine(somatorio);
            
        }

        static bool VerificaSeEhImpar(int numero)
        {
            if(numero % 2 == 0)
            {
                return false;
            }
            
            return true;
        }

        static int SomaImpares(int x, int y)
        {
            int inicio, fim;
            int somatorio = 0;

            if(x > y)
            {
                inicio = y;
                fim = x;
            }
            else 
            {
                inicio = x;
                fim = y;
            }

            for(int i = inicio + 1; i < fim; i++)
            {
                if(VerificaSeEhImpar(i))
                {
                    somatorio += i;
                }
            }

            return somatorio;
        }
    }
}
