namespace MATHEUS_25001971_PROGRAMACAO_III_TRAB1_2026;

internal static class Ex4
{
    internal static void Executar()
    {
        Console.WriteLine("Digite uma frase:");

        string frase = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Consoantes:");

        foreach (var caractere in frase)
        {
            char caractereLow = char.ToLower(caractere);

            if (char.IsLetter(caractere) &&
                caractereLow != 'a' &&
                caractereLow != 'e' &&
                caractereLow != 'i' &&
                caractereLow != 'o' &&
                caractereLow != 'u')
            {
                Console.Write(caractere);
            }
        }

        Console.WriteLine();
    }
}