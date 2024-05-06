
iMetodoPagamento pagamentoCartaoCredito = new CartaoCredito();
pagamentoCartaoCredito.RealizarPagamento(200.00);
Console.WriteLine(pagamentoCartaoCredito.VerificarStatusPagamento());

Console.WriteLine();

iMetodoPagamento pagamentoBoleto = new BoletoBancario();
pagamentoBoleto.RealizarPagamento(34.50);
 Console.WriteLine(pagamentoBoleto.VerificarStatusPagamento());

Console.WriteLine();

iMetodoPagamento pagamentoTranferencia = new TransferenciaBancaria();
pagamentoTranferencia.RealizarPagamento(140.00);
Console.WriteLine(pagamentoTranferencia.VerificarStatusPagamento());