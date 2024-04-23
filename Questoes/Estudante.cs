public class Estudante
{
    public string Matricula { get; set; }
    public string NomeEstudante { get; set; }
    public int Idade { get; set; }

    public Estudante(string Matricula, string NomeEstudante, int Idade)
    {
        this.Matricula = Matricula;
        this.NomeEstudante = NomeEstudante;
        this.Idade = Idade;
    }
}