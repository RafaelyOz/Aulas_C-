public class Pedido
{
    public string Data { get; set; }
    public Cliente Cliente { get; set; }
    public Vendedor Vendedor { get; set; }
    public List<Produto> Produtos { get; }

    public Pedido(Cliente cliente, Vendedor vendedor, string data)
    {
        Cliente = cliente;
        Vendedor = vendedor;
        Produtos = new List<Produto>();
        Data = data;
    }
    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine("Detalhes do Pedido");
        Console.WriteLine($"Data: {Data}");
        Console.WriteLine($"Cliente: {Cliente.NomeCliente} (CPF: {Cliente.Cpf})");
        Console.WriteLine($"Vendedor: {Vendedor.NomeVendedor}(Matricula:{Vendedor.Matricula})");
        Console.WriteLine("Produtos");
        foreach (var produto in Produtos)
        {
            Console.WriteLine($"- {produto.NomeProduto}(Código: {produto.Codigo}), Preço: R${produto.Preco}");
        }
    }
}