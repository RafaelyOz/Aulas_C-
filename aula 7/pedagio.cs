// ./pedagio.cs
public class pedagio
{
    public string nome { get; set; }
    public double preco_eixo { get; set; }

    public bool CobrarPedagio(iVeiculo veiculo)
    {
        //BIZU aquii preciso receber o vallor cobrado e gravar no banco de dados
        double preco_cobrado = veiculo.PagarPedagio(this.preco_eixo);
        Console.WriteLine(preco_cobrado);
        return true;//para evitar o erro enquanto o metodo nao esta pronto
    }
}