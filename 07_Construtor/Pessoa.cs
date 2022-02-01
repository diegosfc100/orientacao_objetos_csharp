using System;

class Pessoa
{
    // CONSTRUTOR
    // É um Método de mesmo nome da classe, porém ele é executado assim q o objeto é instanciado.
    public Pessoa()
    {
        Console.WriteLine("Construtor sem parametro");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor com parametro. Parâmetro >> " + nome);
    }

}