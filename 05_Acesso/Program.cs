using System;

class Program
{

    static void Main(string[] args)
    {
        Produto obj = new Produto();
        obj.nome = "Diego"; // Apenas o atributo 'nome' pode ser instanciado devido seu acesso ser public.
    }
}