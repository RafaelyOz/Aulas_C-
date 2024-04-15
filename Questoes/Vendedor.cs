public class Vendedor
{
    public int Matricula { get; set; }
    public string Cpf { get; set; }
    public string NomeVendedor { get; set; }

    public Vendedor(int matricula, string cpf, string nomeVendedor)
    {
        Matricula = matricula;
        Cpf = cpf;
        NomeVendedor = nomeVendedor;
    }
}