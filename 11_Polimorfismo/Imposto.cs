using System;

// POLIMORFISMO = Muitas - Formas.
// Conceito: Reutilizar Métodos.
// Ex: Enviar uma mesma mensagem para diferentes objetos e fazê-los responder cada um de uma forma.

class Imposto
{
    // Métodos
    // Pra dizer ao Método q ele irá sofrer modificações futuras em outras classes, adicionamos 'virtual'. 
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto padrao do vale alimentação ${salario * 0.1}");
    }

    public virtual void valeTransporte(double salario)
    {
        Console.WriteLine($"Desconto padrão do vale transporte ${salario * 0.06}");
    }
}