namespace MATHEUS_25001971_PROGRAMACAO_III_TRAB1_2026;

internal static class Ex7
{
    internal static void Executar()
    {
        var aluno = new Aluno();

        Console.WriteLine("Digite o nome do aluno:");
        aluno.Nome = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Digite o RA do aluno:");
        aluno.RA = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("Digite a nota da prova:");

        if (!double.TryParse(Console.ReadLine(), out double notaProva) ||
            notaProva < 0 ||
            notaProva > 10)
        {
            Console.WriteLine("Nota da prova inválida! Informe um valor entre 0 e 10.");
            return;
        }

        aluno.NotaProva = notaProva;

        Console.WriteLine("Digite a nota do trabalho:");

        if (!double.TryParse(Console.ReadLine(), out double notaTrabalho) ||
            notaTrabalho < 0 ||
            notaTrabalho > 10)
        {
            Console.WriteLine("Nota do trabalho inválida! Informe um valor entre 0 e 10.");
            return;
        }

        aluno.NotaTrabalho = notaTrabalho;

        Console.WriteLine("Digite a frequência do aluno:");

        if (!double.TryParse(Console.ReadLine(), out double frequencia) ||
            frequencia < 0 ||
            frequencia > 100)
        {
            Console.WriteLine("Frequência inválida! Informe um valor entre 0 e 100.");
            return;
        }

        aluno.Frequencia = frequencia;

        double media = aluno.CalcularMedia();
        bool frequenciaValida = aluno.VerificarFrequencia();

        Console.WriteLine("Dados do aluno:");
        Console.WriteLine($"Nome: {aluno.Nome}");
        Console.WriteLine($"RA: {aluno.RA}");
        Console.WriteLine($"Nota da prova: {aluno.NotaProva}");
        Console.WriteLine($"Nota do trabalho: {aluno.NotaTrabalho}");
        Console.WriteLine($"Média: {media:F2}");
        Console.WriteLine($"Frequência: {aluno.Frequencia}%");

        if (media >= 7 && frequenciaValida)
        {
            Console.WriteLine("Aprovado :)");
        }
        else if (media < 7 && !frequenciaValida)
        {
            Console.WriteLine("Reprovado por média e frequência :(");
        }
        else if (media < 7)
        {
            Console.WriteLine("Reprovado por média :(");
        }
        else
        {
            Console.WriteLine("Reprovado por frequência :(");
        }
    }
}