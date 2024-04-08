public class Vendedor {
    public int Matricula { get; set; }
    public string CpfVendedor { get; set; }
    public string NomeVendedor { get; set; }

    public Vendedor(int matricula, string cpfVendedor, string nomeVendedor) {
        Matricula = matricula;
        CpfVendedor = cpfVendedor;
        NomeVendedor = nomeVendedor;
    }
}
