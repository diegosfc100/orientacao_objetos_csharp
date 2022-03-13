using System;

class Program
{
    static void Main(string[] args)
    {
        Aluno novoAluno = new Aluno();
        novoAluno.mensagem();
        // .nota1, .nota2, media() Não aparecem devido o acesso ser privado, ou seja, estão encapsuldos.
    }
}