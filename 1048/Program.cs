using System;
using System.Globalization;
using System.Threading;  


namespace _1048
{
    class Program
    {

        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine());
            double novoSalario;
            double reajuste;
            double percentualDeReajuste;

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");


            if (salario <= 400)
            {
                percentualDeReajuste = 15;
                reajuste = (percentualDeReajuste / 100) * salario;
                novoSalario = salario + reajuste;
            }
            else if (salario <= 800)
            {
                percentualDeReajuste = 12;
                reajuste = (percentualDeReajuste / 100) * salario;
                novoSalario = salario + reajuste;
            }
            else if (salario <= 1200)
            {
                percentualDeReajuste = 10;
                reajuste = (percentualDeReajuste / 100) * salario;
                novoSalario = salario + reajuste;
            }
            else if (salario <= 2000)
            {
                percentualDeReajuste = 7;
                reajuste = (percentualDeReajuste / 100) * salario;
                novoSalario = salario + reajuste;
            }
            else
            {
                percentualDeReajuste = 4;
                reajuste = (percentualDeReajuste / 100) * salario;
                novoSalario = salario + reajuste;
            }

            Console.WriteLine(string.Format("Novo salario: {0:0.00}", novoSalario));
            Console.WriteLine(string.Format("Reajuste ganho: {0:0.00}", reajuste));
            Console.WriteLine($"Em percentual: {percentualDeReajuste} %");
        }
    }
}
