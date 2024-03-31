

Industria minhaIndustria = new Industria("Refresca S.A.", "Buenos Aires, Argentina", 1975);

Produto aguaSaborizada = new Produto("Água Saborizada", 1, 2.50f);
Produto energetico = new Produto("Bebida Energética", 2, 3.00f);


LinhaProducao linhaAguaSaborizada = new LinhaProducao(1, "Água Saborizada", 500);
linhaAguaSaborizada.AdicionarMaquina(new Maquina(1, "Máquina Azul", "Água Saborizada") { ProdutoProduzido = aguaSaborizada });
linhaAguaSaborizada.AdicionarMaquina(new Maquina(2, "Máquina Verde", "Água Saborizada") { ProdutoProduzido = aguaSaborizada });

LinhaProducao linhaEnergetico = new LinhaProducao(2, "Bebida Energética", 300);
linhaEnergetico.AdicionarMaquina(new Maquina(3, "Máquina Radiante", "Bebida Energética") { ProdutoProduzido = energetico });
linhaEnergetico.AdicionarMaquina(new Maquina(4, "Máquina Radiante", "Bebida Energética") { ProdutoProduzido = energetico });

minhaIndustria.AdicionarLinhaProducao(linhaAguaSaborizada);
minhaIndustria.AdicionarLinhaProducao(linhaEnergetico);

minhaIndustria.ExibirInformacoes();

foreach (var linha in minhaIndustria.LinhasProducao)
{
    linha.ExibirDetalhes();
    foreach (var maquina in linha.Maquinas)
    {
        maquina.ExibirInformacoes();
        maquina.IniciarProducao();

    }
}
