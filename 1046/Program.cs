using System;

namespace _1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;
            string[] entradaValores = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(entradaValores[0]);
            horaFinal = int.Parse(entradaValores[1]);


            //caso dia seguinte
            if((horaInicial <= 12 && horaFinal <= horaInicial))
            {
                duracao = 24 - (horaInicial - horaFinal);
            }
            else if(horaInicial > 12 && horaFinal <= 12) 
            {
                duracao = (24 - horaInicial) + horaFinal;
            }
            else if(horaInicial == horaFinal)
            {
                duracao = 24;
            }
            else 
            {
                duracao = horaFinal - horaInicial;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            
        }
    }
}
