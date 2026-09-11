namespace MATHEUS_25001971_PROGRAMACAO_III_TRAB1_2026;

internal class Aluno
{
    public string Nome { get; set; } = string.Empty;
    public string RA { get; set; } = string.Empty;
    public double NotaProva { get; set; }
    public double NotaTrabalho { get; set; }
    public double Frequencia { get; set; }

    public double CalcularMedia()
    {
        return (NotaProva * 0.7) + (NotaTrabalho * 0.3);
    }

    public bool VerificarFrequencia()
    {
        return Frequencia >= 60;
    }
}