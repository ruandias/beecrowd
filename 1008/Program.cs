using System;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            float valorPorHora = float.Parse(Console.ReadLine());

            float salario = horasTrabalhadas * valorPorHora;

            Console.WriteLine("NUMBER = {0}", numero);
            Console.WriteLine("SALARY = U$ {0}", string.Format("{0:0.00}", salario));
        }
    }
}
