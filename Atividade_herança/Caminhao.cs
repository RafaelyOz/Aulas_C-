public class Caminhao : Veiculo{
    public int CapacidadeCarga{get; set;}

    public Caminhao(string marca, string modelo, int capacidadeCarga) : base(marca, modelo){
        CapacidadeCarga = capacidadeCarga;
    }
}