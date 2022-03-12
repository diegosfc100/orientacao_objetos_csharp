using System;

class Pessoa
{
    // CONSTRUTOR
    // É um MÉTODO de MESMO NOME DA CLASSE, porém ele é EXECUTADO assim q o objeto é instanciado.
    // Todo Construtor é public.
    // Pode criar vários construtores, desde q tenham caracteristicas (parametros) diferentes.
    // Dependendo de como o objeto será instanciado, irá chamar um ou outro.
    public Pessoa()
    {
        Console.WriteLine("Construtor sem parametro");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine($"Meu nome é {nome}");
    }

     public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos.");
    }
    
}