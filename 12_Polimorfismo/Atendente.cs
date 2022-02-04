using System;

class Atendente : Imposto
{
    public override void valeAlimentacao(double salario) // Para sobrescrever um Método, deve adicionar o 'override'.
    {
        Console.WriteLine($"Desconto atendente do vale alimentação ${salario * 0.12}");
    }
}