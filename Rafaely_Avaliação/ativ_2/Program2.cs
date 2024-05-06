// program2.cs
 static void RealizarPagamento(iMetodoPagamento metodoPagamento, double valor)
    {
        metodoPagamento.ProcessarPagamento(valor);
    }

    CartaoCredito cartaoCredito = new CartaoCredito();
    CartaoDebito cartaoDebito = new CartaoDebito();
    Paypal paypal= new Paypal();
    TransferenciaBancaria transferenciaBancaria= new TransferenciaBancaria();

    RealizarPagamento(cartaoCredito, 300.00);
    RealizarPagamento(cartaoDebito, 35.00);
    RealizarPagamento(paypal, 70.00);
    RealizarPagamento(transferenciaBancaria, 200.00);