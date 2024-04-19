public class Moto : Veiculo{
    public int Cilindrada{get;set;}

    public Moto(string marca,string modelo, int cilindrada ) : base( marca, modelo){
        Cilindrada = cilindrada;
    }
}