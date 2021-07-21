using System;

namespace _1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            string especie = Console.ReadLine();
            string tipo = Console.ReadLine();

            if(animal == "vertebrado")
            {
                if(especie == "ave")
                {
                    if(tipo == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else 
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else 
                {
                    if(tipo == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else 
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else 
            {
                if(especie == "inseto")
                {
                    if(tipo == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else 
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else 
                {
                    if(tipo == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else 
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
