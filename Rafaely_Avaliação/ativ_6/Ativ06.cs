public class Veiculo
{
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public int Ano { get; set; }

    public Veiculo(string Modelo, string Marca, int Ano)
    {
        this.Modelo = Modelo;
        this.Marca = Marca;
        this.Ano = Ano;
    }
}
public class Carro : Veiculo
{
    public int NumeroPortas { get; set; }

    public Carro(string Modelo, string Marca, int Ano, int NumeroPortas) : base(Modelo, Marca, Ano)
    {
        this.NumeroPortas = NumeroPortas;
    }
}
public class Moto : Veiculo
{
    public int Cilindrada { get; set; }

    public Moto(string Modelo, string Marca, int Ano, int Cilindrada) : base(Modelo, Marca, Ano)
    {
        this.Cilindrada = Cilindrada;
    }
}
public class Bicicleta : Veiculo
{
    public int NumeroMarchas { get; set; }

    public Bicicleta(string Modelo, string Marca, int Ano, int NumeroMarchas) : base(Modelo, Marca, Ano)
    {
        this.NumeroMarchas = NumeroMarchas;
    }
}