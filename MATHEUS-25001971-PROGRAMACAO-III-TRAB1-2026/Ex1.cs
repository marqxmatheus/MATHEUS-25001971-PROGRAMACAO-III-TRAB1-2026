namespace MATHEUS_25001971_PROGRAMACAO_III_TRAB1_2026;

internal static class Ex1
{
    internal static void Executar()
    {
        Console.WriteLine("Digite o primeiro valor:");

        if (!double.TryParse(Console.ReadLine(), out double valorUm))
        {
            Console.WriteLine("Valor informado inválido!");
            return;
        }

        Console.WriteLine("Digite o segundo valor:");

        if (!double.TryParse(Console.ReadLine(), out double valorDois))
        {
            Console.WriteLine("Valor informado inválido!");
            return;
        }

        Console.WriteLine("Digite a operação desejada:");
        Console.WriteLine("+ - Soma");
        Console.WriteLine("- - Subtração");
        Console.WriteLine("* - Multiplicação");
        Console.WriteLine("/ - Divisão");
        Console.WriteLine("% - Resto da divisão");

        string operacao = Console.ReadLine() ?? string.Empty;

        switch (operacao)
        {
            case "+":
                Console.WriteLine($"Resultado: {valorUm + valorDois}");
                break;

            case "-":
                Console.WriteLine($"Resultado: {valorUm - valorDois}");
                break;

            case "*":
                Console.WriteLine($"Resultado: {valorUm * valorDois}");
                break;

            case "/":
                Console.WriteLine($"Resultado: {valorUm / valorDois}");
                break;

            case "%":
                Console.WriteLine($"Resultado: {valorUm % valorDois}");
                break;

            default:
                Console.WriteLine("Operação inválida.");
                break;
        }
    }
}