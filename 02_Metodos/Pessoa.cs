using System;

class Pessoa
{
    // Podem existir vários métodos com o mesmo nome, desde q tenham parâmetros diferentes.
    // Método_1 / 0 parâmetro

    public void apresentar()
    {
        Console.WriteLine("Olá!");
    }


    // Método_2 / 1 parâmetro
    public void apresentar(string nome)
    {
        Console.WriteLine($"Olá, me chamo {nome}.");
    }


    // Método_3 / 2 parâmetros
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine($"Olá, me chamo {nome} e tenho {idade} anos.");
    }

    

}