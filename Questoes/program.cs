Estudante estudante = new Estudante("20222001", "Manu", 19);

Console.WriteLine("Dados do estudante: ");
Console.WriteLine($"Matricula: {estudante.Matricula}");
Console.WriteLine($"Nome: {estudante.NomeEstudante}");
Console.WriteLine($"Idade:{estudante.Idade}");

 Pessoa pessoa = new Pessoa("123.456.789-00", "João");

Livro livro1 = new Livro("Dom Casmurro", "Machado de Assis");
Livro livro2 = new Livro("Harry Potter", "J.K. Rowling");

pessoa.AdicionarLivro(livro1);
pessoa.AdicionarLivro(livro2);

pessoa.ExibirLivros();

Console.WriteLine("\n");
Cliente cliente = new Cliente("123.334.567.88", "Joana");
Vendedor vendedor = new Vendedor(1222, "222.445.643.78", "Ricardo");
Produto produto1 = new Produto(1, "Batom", 45.50);
Produto produto2 = new Produto(2, "Rimel", 23.00);

Pedido pedido = new Pedido(cliente, vendedor, "13/07/2022");
pedido.AdicionarProduto(produto1);
pedido.AdicionarProduto(produto2);

pedido.ExibirDetalhes();