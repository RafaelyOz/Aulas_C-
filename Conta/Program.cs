

    ContaCorrente contaCorrente = new ContaCorrente{Numero = "123", Saldo = 1000};

    Transacao transacaoSaque = new Transacao("saque", 500, contaCorrente);
    Console.WriteLine($"Saldo atual da conta corrente: {contaCorrente.Saldo}");

    ContaPoupanca contaPoupanca = new ContaPoupanca { Numero = "456", Saldo = 2000 };

   
    Transacao transacaoDeposito = new Transacao("deposito", 1000, contaPoupanca);
    Console.WriteLine($"Saldo atual da conta poupança: {contaPoupanca.Saldo}");
