using System; 
using System.Collections.Generic;
using System.Linq;

class URI {

static void Main()
        {
           int quantidadeEntrada = int.Parse(Console.ReadLine());
            var evenList = new List<int>();
            var oddList = new List<int>();

           for (int i = 0; i < quantidadeEntrada; i++)
            {   
                int number = int.Parse(Console.ReadLine());

                var even = IsEven(number);

                if (even)
                    evenList.Add(number);
                else 
                    oddList.Add(number);
            }

            evenList.Sort();
            oddList.Sort();
            oddList.Reverse();
            
            PrintList(evenList);
            PrintList(oddList);
        }

        static bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }

            return false;
        }

        static void PrintList(List<int> numbers)
        {
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

}