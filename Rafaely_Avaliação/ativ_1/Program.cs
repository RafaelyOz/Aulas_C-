 Gerente gerente = new Gerente
        {
            NomeFuncionario = "Ana",
            SalarioBase = 4500,
            Bonus = 500
        };

        Vendedor vendedor = new Vendedor
        {
            NomeFuncionario = "Andre",
            SalarioBase = 1200,
            Comissao = 300
        };

        Console.WriteLine($"Salário do gerente {gerente.NomeFuncionario}: {gerente.CalcularSalario()}");
        Console.WriteLine($"Salário do vendedor {vendedor.NomeFuncionario}: {vendedor.CalcularSalario()}");
