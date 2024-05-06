public class Curso
{
    public string Nome { get; set; }
    public string Idioma { get; set; }
    public bool Concluido { get; set; }

    public Curso(string Nome, string Idioma){
        this.Nome = Nome;
        this.Idioma = Idioma;
        this.Concluido = false;
    }

    public virtual void GerarCertificado()
    {
        if (Concluido)
        {
            Console.WriteLine($"Certificado de conclusão do curso de {Idioma} - {Nome}");
        }
        else
        {
            Console.WriteLine($"O curso de {Idioma} - {Nome} ainda não foi concluído.");
        }
    }
}
public class CursoAvancado : Curso
{
    public List<double> Notas { get; set; }

    public CursoAvancado(string nome, string idioma) : base(nome, idioma)
    {
        this.Notas = new List<double>();
    }

    public override void GerarCertificado()
    {
        if (Concluido)
        {
            Console.WriteLine($"Certificado de conclusão do curso avançado de {Idioma} - {Nome}");
            CalcularMediaNotas();
        }
        else
        {
            Console.WriteLine($"O curso avançado de {Idioma} - {Nome} ainda não foi concluído.");
        }
    }

    public void CalcularMediaNotas()
    {
        if (Notas.Count > 0)
        {
            double soma = 0;
            foreach (var nota in Notas)
            {
                soma += nota;
            }
            double media = soma / Notas.Count;
            Console.WriteLine($"Média de notas: {media}");
        }
        else
        {
            Console.WriteLine("Nenhuma nota disponível para calcular a média.");
        }
    }
}