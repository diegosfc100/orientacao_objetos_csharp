using System;

class Pessoa
{
    // Podem existir vários MÉTODOS com o mesmo nome, desde q tenham PARÂMETROS DIFERENTES.
    // Método01 / 0 parâmetro

    public void apresentar()
    {
        Console.WriteLine("Olá!");
    }

    // Método02 / 1 parâmetro
    public void apresentar(string nome)
    {
        Console.WriteLine($"Olá, me chamo {nome}.");
    }

    // Método03 / 2 parâmetros
    public void apresentar(string nome, int idade)
    {
        Console.WriteLine($"Olá, me chamo {nome} e tenho {idade} anos.");
    }

    // Vários métodos com o mesmo nome, porém oq os diferencia são os parametros.
    

}