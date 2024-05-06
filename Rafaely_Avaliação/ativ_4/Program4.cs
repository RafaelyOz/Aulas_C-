Produto produto = new Produto("Bolsa", 140.00, 20);

produto.AdicionarEstoque(15);

produto.RemoverEstoque(5);

double valorTotal = produto.CalcularValorTotal();
Console.WriteLine("O valor total em estoque é: " + valorTotal);
