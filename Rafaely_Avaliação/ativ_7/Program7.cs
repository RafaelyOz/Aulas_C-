/*Utilizei o chat para a lógica dos metodos das contas */


ContaCorrente contaCorrente = new ContaCorrente("12345", 2000, 10);
contaCorrente.Depositar(2000);
contaCorrente.Sacar(800);
contaCorrente.ConsultarSaldo();

Console.WriteLine();

ContaPoupanca contaPoupanca = new ContaPoupanca("65478", 4500, 0.05);
contaPoupanca.Depositar(4500);
contaPoupanca.CalcularJuros();
contaPoupanca.ConsultarSaldo();

Console.WriteLine();

ContaEmpresarial contaEmpresarial = new ContaEmpresarial("89707", 3000, 2000);
contaEmpresarial.Depositar(3000);
contaEmpresarial.ConsultarSaldo();
contaEmpresarial.VerificarSaldoMinimo();
contaEmpresarial.Sacar(1500);
contaEmpresarial.ConsultarSaldo();
contaEmpresarial.VerificarSaldoMinimo();
