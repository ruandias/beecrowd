using System;

namespace _2712
{
    class Program
    {
        static void Main(string[] args)
        {
            int testes = 0;
            string placa;
            string cadeiaCaracter;

            string N = Console.ReadLine();

            if (int.Parse(N) >= 0 && int.Parse(N) < 1000)
            {
                testes = int.Parse(N);
            }


            while (testes > 0)
            {
                cadeiaCaracter = Console.ReadLine();

                if (cadeiaCaracter.Length >= 1 && cadeiaCaracter.Length <= 100)
                {
                    placa = cadeiaCaracter;

                    if (VerificaPlaca(placa))
                        Rodizio(placa);
                    else
                        Console.WriteLine("FAILURE");
                    testes--;
                }
            }
        }

        static bool VerificaPlaca(string placa)
        {
            string primeiraParte = placa.Substring(0, 3);

            for (int i = 0; i < primeiraParte.Length; i++)
            {
                if (!char.IsLetter(primeiraParte[i]) || !char.IsUpper(primeiraParte[i]))
                    return false;
            }

            string segundaParte = placa.Substring(3, 1);

            if (!segundaParte.Contains('-'))
                return false;

            string terceiraParte = placa.Substring(4, 4);

            for (int i = 0; i < terceiraParte.Length; i++)
            {
                if (!char.IsDigit(terceiraParte[i]))
                    return false;
            }

            return true;
        }

        static void Rodizio(string placa)
        {
            int tamanho = placa.Length - 1;

            char ultimoDigito = placa[tamanho];

            switch (ultimoDigito)
            {
                case '1':
                case '2':
                    Console.WriteLine(Dias.MONDAY.ToString());
                    break;
                case '3':
                case '4':
                    Console.WriteLine(Dias.TUESDAY.ToString());
                    break;
                case '5':
                case '6':
                    Console.WriteLine(Dias.WEDNESDAY.ToString());
                    break;
                case '7':
                case '8':
                    Console.WriteLine(Dias.THURSDAY.ToString());
                    break;
                case '9':
                case '0':
                    Console.WriteLine(Dias.FRIDAY.ToString());
                    break;
            }
        }
    }

    public enum Dias
    {
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY
    }
}