public class ContaCorrente : iConta{
    public string Numero{ get; set; }
    public double Saldo{ get; set; }

    public double depositar(double valor){
        this.Saldo += valor;
        return this.Saldo;
    }
    
    public double sacar(double valor){
        this.Saldo -= valor;
        return this.Saldo;
    }
}