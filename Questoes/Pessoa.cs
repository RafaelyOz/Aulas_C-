using System;
using System.Collections.Generic;

public class Pessoa {
    public string Cpf { get; set; }
    public string Nome { get; set; }
    public List<Livro> Livros { get; set; }

    public Pessoa(string cpf, string nome) {
        Cpf = cpf;
        Nome = nome;
        Livros = new List<Livro>();
    }

    public void AdicionarLivro(Livro livro) {
        Livros.Add(livro);
    }

    public void ExibirLivros() {
        Console.WriteLine($"Livros da pessoa {Nome} (CPF: {Cpf}):");
        for (int i = 0; i < Livros.Count; i++) {
            Console.WriteLine($"Título: {Livros[i].Titulo}, Autor: {Livros[i].Autor}");
        }
    }
}

public class Livro {
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public Livro(string titulo, string autor) {
        Titulo = titulo;
        Autor = autor;
    }
}

