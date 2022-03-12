using System;

class Program
{
    static void Main(string[] args)
    {
        Aluno obj = new Aluno();

        obj.nome = "Diego";
        obj.nota1 = 10;
        obj.nota2 = 6;
        obj.mensagem();
    }
}