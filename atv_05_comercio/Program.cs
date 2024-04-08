
        var vendedor = new Vendedor(1, "1122334455", "José");
        var cliente = new Cliente("Ana", "01234567890");
        var venda = new Venda(vendedor, cliente);

        var produto1 = new Produto(1, "Carne", 34.90f);
        var produto2 = new Produto(2, "Macarrão", 12.50f);
        var produto3 = new Produto(3,"Molho de tomate", 5.00f);
        var produto4 = new Produto(4,"Coca-cola",10.00f);

        venda.AdicionarProduto(produto1);
        venda.AdicionarProduto(produto2);
        venda.AdicionarProduto(produto3);
        venda.AdicionarProduto(produto4);

        Console.WriteLine("Valor total da venda: " + venda.CalcularValorTotal());
    