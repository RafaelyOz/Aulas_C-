public class ContaBancaria
{
    public string NumeroConta { get; set; }
    public double Saldo { get; set; }

    public ContaBancaria(string NumeroConta, double Saldo)
    {
        this.NumeroConta = NumeroConta;
        this.Saldo = Saldo;
    }

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine("Deposito de R$" + valor + "realizado. Novo saldo R$ " + Saldo);
    }

    public virtual void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
            Console.WriteLine("Saque de R$ " + valor + " realizado. Novo saldo: R$ " + Saldo);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public virtual void ConsultarSaldo()
    {
        Console.WriteLine("Saldo da conta " + NumeroConta + ": R$ " + Saldo);
    }
}
public class ContaCorrente : ContaBancaria
{
    public double TaxaManutencao { get; set; }

    public ContaCorrente(string NumeroConta, double SaldoInicial, double TaxaManutencao) : base(NumeroConta, SaldoInicial)
    {
        this.TaxaManutencao = TaxaManutencao;
    }

    public override void Sacar(double valor)
    {
        base.Sacar(valor + TaxaManutencao);
    }
}
public class ContaEmpresarial : ContaBancaria
{
    public double SaldoMinimo { get; set; }

    public ContaEmpresarial(string NumeroConta, double SaldoInicial, double SaldoMinimo) : base(NumeroConta, SaldoInicial)
    {
        this.SaldoMinimo = SaldoMinimo;
    }

    public void VerificarSaldoMinimo()
    {
        if (Saldo < SaldoMinimo)
        {
            Console.WriteLine("Saldo abaixo do mínimo permitido. Saldo atual: R$" + Saldo + ". Saldo mínimo exigido: R$" + SaldoMinimo);
        }
        else
        {
            Console.WriteLine("Saldo da conta empresarial " + NumeroConta + ": R$" + Saldo);
        }
    }
}

public class ContaPoupanca : ContaBancaria
{
    public double TaxaJuros { get; set; }

    public ContaPoupanca(string NumeroConta, double SaldoInicial, double TaxaJuros) : base(NumeroConta, SaldoInicial)
    {
        this.TaxaJuros = TaxaJuros;
    }

    public void CalcularJuros()
    {
        double juros = Saldo * TaxaJuros;
        Depositar(juros);
        Console.WriteLine("Juros de R$" + juros + " calculados e adicionados à conta. Novo saldo: R$ " + Saldo);
    }
}
