public class Livro : ItemBiblioteca, IImpressao{
    public int NumeroPaginas{ get; set; }

    public override void ExibirDetalhes(){

        Console.WriteLine($"Livro: {Titulo} - Autor: {Autor} - Número de Páginas: {NumeroPaginas}");
    }

    public void Imprimir(){
        ExibirDetalhes();
    }
}