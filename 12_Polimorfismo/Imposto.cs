using System;

class Imposto
{
    // Métodos
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto padrao do vale alimentação $ {salario * 0.1}");
    }

    public virtual void valeTrasnporte(double salario)
    {
        Console.WriteLine($"Desconto padrão do vale transporte $ {salario * 0.06}");
    }
}