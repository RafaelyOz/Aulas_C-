public class Produto {
    public int Codigo { get; set; }
    public string NomeProduto { get; set; }
    public float Preco { get; set; }

    public Produto(int codigo, string nomeProduto, float preco) {
        Codigo = codigo;
        NomeProduto = nomeProduto;
        Preco = preco;
    }
}
