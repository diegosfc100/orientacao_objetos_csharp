using System;

class Gerente : Imposto
{
    public override void valeAlimentacao(double salario) // Para sobrescrever um Método, deve adicionar o 'override'.
    {
        Console.WriteLine($"Desconto gerente do vale alimentação ${salario * 0.15}");

    }
}