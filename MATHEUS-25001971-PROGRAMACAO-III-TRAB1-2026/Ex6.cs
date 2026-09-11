namespace MATHEUS_25001971_PROGRAMACAO_III_TRAB1_2026;

internal static class Ex6
{
    internal static void Executar()
    {
        var livro = new Livro();

        Console.WriteLine("Digite o título do livro:");
        livro.Titulo = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Digite o autor do livro:");
        livro.Autor = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Digite o valor do livro:");

        if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
        {
            Console.WriteLine("Valor informado inválido!");
            return;
        }

        livro.Valor = valor;

        Console.WriteLine("Livro cadastrado:");
        Console.WriteLine($"Título: {livro.Titulo}");
        Console.WriteLine($"Autor: {livro.Autor}");
        Console.WriteLine($"Valor: R$ {livro.Valor:F2}");
    }
}