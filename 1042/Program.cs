// Leia 3 valores inteiros e ordene-os em ordem crescente. 
// No final, mostre os valores em ordem crescente, uma linha em branco e em seguida, 
// os valores na sequência como foram lidos.

// 
// Exemplo de Entrada
// 7 21 -14

// Exemplo de Saída
// -14
// 7
// 21

// 7
// 21
// -14


string[] enterValues = Console.ReadLine().Split(' ');

int[] intArray = ConvertToInt(enterValues);

int[] sortedArray = (int[])intArray.Clone();

BubbleSort(sortedArray);

PrintArray(sortedArray);

Console.WriteLine();

PrintArray(intArray);

static int[] ConvertToInt(string[] arrayString)
{
    int length = arrayString.Length;
    int[] intValues = new int[length];

    for (int i = 0; i < length; i++)
    {
        intValues[i] = int.Parse(arrayString[i]);
    }

    return intValues;
}

static void PrintArray(int[] array)
{
    foreach (var value in array)
    {
        Console.WriteLine(value);
    }
}

static void BubbleSort(int[] array)
{
    int n = array.Length;
    bool swapped;

    for (int i = 0; i < n - 1; i++)
    {
        swapped = false;
        for (int j = 0; j < n - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                swapped = true;
            }
        }
        if (!swapped)
            break;
    }
}
