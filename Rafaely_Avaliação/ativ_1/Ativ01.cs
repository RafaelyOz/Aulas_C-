public class Funcionario
{
    public string NomeFuncionario { get; set; }
    public double SalarioBase { get; set; }

    public virtual double CalcularSalario()
    {
        return SalarioBase;
    }
}
public class Gerente : Funcionario
{
    public double Bonus { get; set; }

    public override double CalcularSalario()
    {
        return SalarioBase + Bonus;
    }
}
public class Vendedor : Funcionario
{
    public double Comissao { get; set; }

    public override double CalcularSalario()
    {
        return SalarioBase + Comissao;
    }
}