namespace MATHEUS_25001971_PROGRAMACAO_III_TRAB1_2026;

internal static class Ex2
{
    internal static void Executar()
    {
        Console.WriteLine("Digite uma frase:");

        string frase = Console.ReadLine() ?? string.Empty;

        var quantVogais = 0;

        foreach (var caractere in frase.ToLower())
        {
            if (caractere == 'a' ||
                caractere == 'e' ||
                caractere == 'i' ||
                caractere == 'o' ||
                caractere == 'u')
            {
                quantVogais++;
            }
        }

        Console.WriteLine($"Quantidade de vogais: {quantVogais}");
    }
}