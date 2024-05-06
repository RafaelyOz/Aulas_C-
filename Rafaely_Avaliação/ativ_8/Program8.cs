Curso curso1 = new Curso("Inglês Básico", "Inglês");
curso1.GerarCertificado();

Console.WriteLine();

CursoAvancado curso2 = new CursoAvancado("Espanhol Avançado", "Espanhol");
curso2.Concluido = true;
curso2.Notas = new List<double> { 8.5, 9.0, 7.5 };
curso2.GerarCertificado();
