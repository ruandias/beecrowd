int quantidadeEntrada = int.Parse(Console.ReadLine()!);

for (int i = 0; i < quantidadeEntrada; i++)
{

    var evenList = new List<int>();
    var oddList = new List<int>();

    int numero = int.Parse(Console.ReadLine()!);
    if (numero > 0)
    {
        if (numero % 2 == 0)
        {
            evenList.Add(numero);
        }
        else
        {
            oddList.Add(numero);
        }
    }


}

