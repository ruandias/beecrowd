using System.Text;

class Program
{
    static void Main()
    {
        string input = "This is a dancing sentence";
        
        // Usamos StringBuilder para evitar alocações O(N²) na memória
        StringBuilder output = new StringBuilder();
        
        // Flag booleana: a primeira letra encontrada DEVE ser maiúscula
        bool makeUpper = true;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                // Aplica a formatação baseada na flag
                if (makeUpper)
                {
                    output.Append(char.ToUpper(c));
                }
                else
                {
                    output.Append(char.ToLower(c));
                }

                // Inverte a flag APENAS quando processamos uma letra
                makeUpper = !makeUpper;
            }
            else
            {
                // Se for espaço ou pontuação, apenas preserva e NÃO altera a flag
                output.Append(c);
            }
        }

        Console.WriteLine(output.ToString());
    }
}