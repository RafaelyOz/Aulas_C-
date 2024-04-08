using System.Collections.Generic;

public class Venda {
    public Vendedor Vendedor { get; set; }
    public Cliente Cliente { get; set; }
    public List<Produto> ProdutosVendidos { get; } 

    public Venda(Vendedor vendedor, Cliente cliente) {
        Vendedor = vendedor;
        Cliente = cliente;
        ProdutosVendidos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto) {
        ProdutosVendidos.Add(produto);
    }

    public float CalcularValorTotal() {
        float total = 0;
        foreach (var produto in ProdutosVendidos) {
            total += produto.Preco;
        }
        return total;
    }
}
