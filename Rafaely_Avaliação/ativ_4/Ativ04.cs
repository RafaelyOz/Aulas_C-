public class Produto
{
    public string NomeProduto { get; set; }
    public double Preco { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public Produto(string NomeProduto, double Preco, int QuantidadeEmEstoque)
    {
        this.NomeProduto = NomeProduto;
        this.Preco = Preco;
        this.QuantidadeEmEstoque = QuantidadeEmEstoque;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            QuantidadeEmEstoque += quantidade;
        }
        else
        {
            Console.WriteLine("A quantidade para ser adicionada deve ser positiva");
        }
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade > 0)
        {
            if (quantidade <= QuantidadeEmEstoque)
            {
                QuantidadeEmEstoque -= quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente");
            }
        }
        else
        {
            Console.WriteLine("A quantidade a ser removida deve ser positiva");
        }
    }

    public double CalcularValorTotal()
    {
        Console.WriteLine($"Preço: {Preco}");
        Console.WriteLine($"Quantidade em estoque: {QuantidadeEmEstoque}");

        return Preco * QuantidadeEmEstoque;
    }


}