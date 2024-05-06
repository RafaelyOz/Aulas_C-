Filme filme1 = new Filme("Viagem de Chihiro", "Animação", 135, true);
filme1.RegistrarLocacao();
filme1.RegistrarDevolucao();
bool disponivel1 = filme1.VerificarDisponibilidade();
Console.WriteLine("O Filme " + filme1.Titulo + " está disponível para locação? " + disponivel1 + "\n");

Filme filme2 = new Filme("Cartas para Julieta", "Romance", 105, false);
filme2.RegistrarLocacao();
filme2.RegistrarDevolucao();
bool disponivel2 = filme2.VerificarDisponibilidade();
Console.WriteLine("O Filme " + filme2.Titulo + " está disponível para locação? " + disponivel2 + "\n");

Filme filme3 = new Filme("The Batman", "Ação", 176, true);
filme3.RegistrarLocacao();
filme3.RegistrarDevolucao();
filme3.RegistrarLocacao();
bool disponivel3 = filme3.VerificarDisponibilidade();
Console.WriteLine("O Filme " + filme3.Titulo + " está disponível para locação? " + disponivel3 + "\n");
