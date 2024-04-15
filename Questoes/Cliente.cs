public class Cliente
{
    public string Cpf { get; set; }
    public string NomeCliente { get; set; }

    public Cliente(string cpf, string nomeCliente)
    {
        Cpf = cpf;
        NomeCliente = nomeCliente;
    }
}