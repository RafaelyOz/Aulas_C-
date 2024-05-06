//Saída do Sobrecarga
Cachorro cachorro1 = new Cachorro();
cachorro1.ExibirDados();

Cachorro cachorro2 = new Cachorro("Fifi","Sptiz Alemão");
cachorro2.ExibirDados();

Console.WriteLine("");

//Saída do Sobrescrita

Animal animal = new Animal();
Vaca vaca = new Vaca();

animal.EmitirSom();

vaca.EmitirSom();
