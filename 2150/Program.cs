using System;

namespace _2150
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string vogaisAlienigenas = Console.ReadLine();

                string frase = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(vogaisAlienigenas))
                    break;
                if (string.IsNullOrWhiteSpace(frase))
                    break;
                
                int totalVogais = ContaVogal(frase, vogaisAlienigenas);

                Console.WriteLine(totalVogais);
            }
        }

        static int ContaVogal(string umaFrase, string vogaisAlienigenas)
        {
            int contabilizaVogais = 0;
            for (int i = 0; i < vogaisAlienigenas.Length; i++)
            {
                for (int j = 0; j < umaFrase.Length; j++)
                {
                    if (vogaisAlienigenas[i] == umaFrase[j])
                    {
                        contabilizaVogais++;
                    }
                }
            }

            return contabilizaVogais;
        }
    }
}
