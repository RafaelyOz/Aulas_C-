public interface iMetodoPagamento
{
    void RealizarPagamento(double valor);
    string VerificarStatusPagamento();
}
public class CartaoCredito : iMetodoPagamento
{
    public void RealizarPagamento(double valor)
    {
        Console.WriteLine("Pagamento de R$ " + valor + " processado com cartão de crédito");
    }

    public string VerificarStatusPagamento()
    {
        return "Pagamento com cartão de crédito autorizado";
    }
}
public class BoletoBancario : iMetodoPagamento
{
    public void RealizarPagamento(double valor)
    {
        Console.WriteLine("Pagamento de R$ " + valor + " processado com boleto bancário");
    }

    public string VerificarStatusPagamento()
    {
        return "Boleto bancário emitido e aguardando pagamento";
    }
}
public class TransferenciaBancaria : iMetodoPagamento
{
    public void RealizarPagamento(double valor)
    {
        Console.WriteLine("Pagamento de R$ " + valor + " processado com transferência bancária");
    }

    public string VerificarStatusPagamento()
    {
        return "Transferência bancária concluída";
    }
}

