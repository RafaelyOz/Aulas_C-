public class Filme
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public Filme(string Titulo, string Genero, int Duracao, bool Disponivel)
    {
        this.Titulo = Titulo;
        this.Genero = Genero;
        this.Duracao = Duracao;
        this.Disponivel = Disponivel;
    }

    public void RegistrarLocacao()
    {
        if (Disponivel)
        {
            Disponivel = false;
            Console.WriteLine("O Filme " + Titulo + " foi locado com sucesso.");

        }
        else
        {
            Console.WriteLine("Filme " + Titulo + " não está disponivel");
        }
    }

    public void RegistrarDevolucao()
    {
        if (!Disponivel)
        {
            Disponivel = true;
            Console.WriteLine("Filme " + Titulo + " foi devolvido");
        }
        else
        {
            Console.WriteLine("Filme " + Titulo + " está disponivel para locação");
        }
    }

    public bool VerificarDisponibilidade()
    {
        return Disponivel;
    }

}