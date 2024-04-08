public class Cliente {
    public string NomeCliente { get; set; }
    public string CpfCliente { get; set; }

    public Cliente(string nomeCliente, string cpfCliente) {
        NomeCliente = nomeCliente;
        CpfCliente = cpfCliente;
    }
}
