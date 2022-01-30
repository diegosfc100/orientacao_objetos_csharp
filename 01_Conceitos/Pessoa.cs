using System;

// CLASSE: É como se fosse um molde. (Ex: Pessoa)
// ATRIBUTOS: Caracteríscias. (Ex: nome, idade, peso, sexo...)
// MÉTODOS: São Funções, servem como ações. (Ex: Cumprimentar, Codar, Apresentar-se...)

class Pessoa
{

    public string nome;
    public int idade;


    public void mensagem()
    {
        Console.WriteLine($"Prazer, me chamo {nome} e tenho {idade} anos.");
    }

    // public: significa q qlqr arquivo .cs terá acesso/visualização ao atributo ou método.
    // void: significa q o método não retornará nada, vazio.
}