public class Carro : Veiculo{
    public int NumeroPortas{ get; set; }

    public Carro(string marca, string modelo, int numeroPortas) : base( marca, modelo){
        NumeroPortas = numeroPortas;
    }
}