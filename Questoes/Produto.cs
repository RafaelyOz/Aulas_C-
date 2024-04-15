public class Produto
{
    public int Codigo { get; set; }
    public string NomeProduto { get; set; }
    public double Preco { get; set; }

    public Produto(int codigo, string nomeProduto, double preco)
    {
        Codigo = codigo;
        NomeProduto = nomeProduto;
        Preco = preco;
    }
}