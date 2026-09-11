namespace MATHEUS_25001971_PROGRAMACAO_III_TRAB1_2026;

internal static class Ex5
{
    internal static void Executar()
    {
        Console.WriteLine("Digite a idade:");

        if (!int.TryParse(Console.ReadLine(), out int idade))
        {
            Console.WriteLine("Idade informada inválida!");
            return;
        }

        if (idade <= 19)
        {
            Console.WriteLine("Você é jovem.");
        }
        else if (idade <= 59)
        {
            Console.WriteLine("Você é adulto.");
        }
        else if (idade >= 60)
        {
            Console.WriteLine("Você é idoso");
        }
        else
        {
            Console.WriteLine("Ninguém tem essa idade.");
        }
    }
}