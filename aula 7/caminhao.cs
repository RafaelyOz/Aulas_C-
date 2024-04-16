public class Caminhao : iVeiculo {

    public int eixos{get; set;}
    public string TipodeCarga{get; set;}
    public bool carga_risco{get; set;}


    public double PagarPedagio(double preco){
        return preco * this.eixos;
    }

}