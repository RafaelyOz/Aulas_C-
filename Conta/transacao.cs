public class Transacao{
    iConta conta { get; set; }
    public Transacao(string oper, double valorOper, iConta contaOper){

        this.conta = contaOper;
        if(oper=='saque'){
            this.conta.sacar(valorOper);
        }
        if(oper=='deposito'){
            this.conta.depositar(valorOper);
        }
    }
}