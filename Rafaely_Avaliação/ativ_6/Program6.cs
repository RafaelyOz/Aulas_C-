Carro carro = new Carro("Corcel Gt", "Ford", 1977, 2);
Moto moto = new Moto("PCX Sport", "Honda", 2018, 152);
Bicicleta bicicleta = new Bicicleta("Ultra Bikes Tork", "Ultra Bikes", 2020, 18);

Console.WriteLine("Carro:");
Console.WriteLine("Modelo: " + carro.Modelo + " , Marca: " + carro.Marca + ", Ano: " + carro.Ano + ", Portas: " + carro.NumeroPortas);

Console.WriteLine("\nMoto:");
Console.WriteLine("Modelo: " + moto.Modelo + " , Marca: " + moto.Marca + ", Ano: " + moto.Ano + ", Cilindradas: " + moto.Cilindrada + " cc");


Console.WriteLine("\nBicicleta:");
Console.WriteLine("Modelo: " + bicicleta.Modelo + " , Marca: " + bicicleta.Marca + ", Ano: " + bicicleta.Ano + ", Marchas: " + bicicleta.NumeroMarchas);
