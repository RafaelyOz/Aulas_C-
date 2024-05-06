public interface iMetodoPagamento{
    void ProcessarPagamento(double valor);
    void CancelarPagamento();
}

public class CartaoCredito : iMetodoPagamento{
    
    public void ProcessarPagamento(double valor){
        Console.WriteLine($"Pagamento de valor {valor:C} processado com cartao de crédito");
    }

    public void CancelarPagamento(){
        Console.WriteLine($"Pagamento com cartão de crédito cancelado");
    }
}

public class CartaoDebito : iMetodoPagamento{
    
    public void ProcessarPagamento(double valor){
        Console.WriteLine($"Pagamento de valor {valor:C} processado com cartao de débito");
    }

    public void CancelarPagamento(){
        Console.WriteLine($"Pagamento com cartão de débito cancelado");
    }
}

public class Paypal : iMetodoPagamento{
    
    public void ProcessarPagamento(double valor){
        Console.WriteLine($"Pagamento de valor {valor:C} processado com Paypal");
    }

    public void CancelarPagamento(){
        Console.WriteLine($"Pagamento com Paypal");
    }
}

public class TransferenciaBancaria : iMetodoPagamento{
    
    public void ProcessarPagamento(double valor){
        Console.WriteLine($"Pagamento de {valor:C} processado por transfência bancária");

    }

    public void CancelarPagamento(){
        Console.WriteLine("Pagamento por transfência bancária cancelado.");
    }
}