using System;

class Program
{

    static void Main(string[] args)
    {
        Produto obj = new Produto();
        obj.nome = "Diego"; // Apenas o atributo 'nome' pode ser instanciado devido seu acesso ser public.
        //obj.peso      (Objeto com visualização restrita.)
        //obj.sobrenome (Objeto com visualização restrita.)
    }
}