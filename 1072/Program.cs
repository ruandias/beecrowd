

// Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
// Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações.
// Entrada

// A primeira linha da entrada contém um valor inteiro N (N < 10000), que indica o número de casos de teste.
// Cada caso de teste a seguir é um valor inteiro X (-107 < X <107).
 
// Saída

// Para cada caso, imprima quantos números estão dentro (in) e quantos valores estão fora (out) do intervalo.


// versão menos otimizada
// int num = int.Parse(Console.ReadLine());

// var input = new List<int>();
// var output = new List<int>();


// for (int i = 0; i < num; i++)
// {
//     var n = int.Parse(Console.ReadLine());

//     if (n >= 10 && n <= 20)
//     {
//         input.Add(n);
//     }
//     else
//     {
//         output.Add(n);
//     }
// }

// Console.WriteLine($"{input.Count} in");
// Console.WriteLine($"{output.Count} out");

// versão otimizada
// 1. Lê a quantidade de casos de teste
        int n = int.Parse(Console.ReadLine());

        // 2. Variáveis de contagem (Espaço O(1))
        int inCount = 0;
        int outCount = 0;

        // 3. Processamento em tempo O(N)
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());

            if (x >= 10 && x <= 20)
            {
                inCount++;
            }
            else
            {
                outCount++;
            }
        }

        // 4. Imprime os resultados no formato esperado
        Console.WriteLine($"{inCount} in");
        Console.WriteLine($"{outCount} out");