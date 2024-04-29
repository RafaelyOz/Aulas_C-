public class Revista : ItemBiblioteca, IImpressao
{
    public int Edicao{ get; set; }

    public override void ExibirDetalhes(){
        Console.WriteLine($"Revista: {Titulo} - Autor: {Autor} - Edição: {Edicao}");
    }

    public void Imprimir(){
        ExibirDetalhes();
    }
}