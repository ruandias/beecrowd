

// Leia um valor inteiro N. Apresente todos os números entre 1 e 10000 que divididos por N dão resto igual a 2.
// Entrada

// A entrada contém um valor inteiro N (N < 10000).
// Saída

// Imprima todos valores que quando divididos por N dão resto = 2, um por linha.


int n = int.Parse(Console.ReadLine());
var max = 10000;

for (int i = 1; i <= max; i ++)
{
    if (i % n == 2)
        Console.WriteLine(i);
}

