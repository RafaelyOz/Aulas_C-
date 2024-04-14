public class Estudante{
    public string Matricula{ get; set; }
    public string NomeEstudante { get; set; }
    public int Idade{ get; set; }

    public Estudante(string matricula, string nomeEstudante, int idade){
        Matricula = matricula;
        NomeEstudante = nomeEstudante;
        Idade = idade;
    }
}