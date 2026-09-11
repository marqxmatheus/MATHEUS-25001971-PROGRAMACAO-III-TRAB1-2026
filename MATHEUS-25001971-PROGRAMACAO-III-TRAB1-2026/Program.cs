namespace MATHEUS_25001971_PROGRAMACAO_III_TRAB1_2026;

internal class Program
{
    static void Main(string[] args)
    {
        var opcao = 0;

        do
        {
            Console.WriteLine("Escolha qual exercício executar:");
            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Quantidade de vogais");
            Console.WriteLine("3 - Escrever vogais");
            Console.WriteLine("4 - Escrever consoantes");
            Console.WriteLine("5 - Encontrar faixa etária");
            Console.WriteLine("6 - Cadastrar livro");
            Console.WriteLine("7 - Verificar aprovação de alunos");
            Console.WriteLine("0 - Sair");

            if (!int.TryParse(Console.ReadLine() ?? string.Empty, out opcao))
            {
                Console.WriteLine("Não sei do que você tá falando...");
                opcao = 1;
                continue;
            }

            switch (opcao)
            {
                case 0:
                    Console.WriteLine("Valeu!");
                    break;

                case 1:
                    Ex1.Executar();
                    break;

                case 2:
                    Ex2.Executar();
                    break;

                case 3:
                    Ex3.Executar();
                    break;

                case 4:
                    Ex4.Executar();
                    break;

                case 5:
                    Ex5.Executar();
                    break;

                case 6:
                    Ex6.Executar();
                    break;

                case 7:
                    Ex7.Executar();
                    break;

                default:
                    Console.WriteLine($"Não temos essa opção... ainda.");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }

        } while (opcao != 0);
    }
}