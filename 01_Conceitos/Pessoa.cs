using System;

// CLASSE: É como se fosse um molde. (Ex: Pessoa)
// ATRIBUTOS: Caracteríscias. (Ex: nome, idade, peso, sexo...)
// MÉTODOS: São Funções, servem como ações. (Ex: Cumprimentar, Codar, Apresentar-se...)

public class Pessoa
{

    public string Nome{get; set;}
    public int Idade{get; set;}


    public void Mensagem() // Métodos sempre iniciam com letra maiuscula
    {
        Console.WriteLine($"Prazer, me chamo {Nome} e tenho {Idade} anos.");
    }

    // public: significa q qlqr arquivo .cs terá acesso/visualização ao atributo ou método.
    // void: significa q o método não retornará nada, vazio.
}
