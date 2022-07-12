using System;

class Program
{
    static void Main(string[] args)
    {
        // Sem precisar Instanciar/Criar Objeto eu posso acessar um método/atributo estático. >>> 
        // Método
        Exemplo.soma(10, 50);

        // Atributo
        string name = Exemplo.nome;
        Console.WriteLine($"Bem-Vindo, {name }.");

        double resultado = Calculadora.Somar(8,2);
        Console.WriteLine($"Resultado da soma: {resultado}");

        var empregado1 = new Empregado("José");
        Console.WriteLine(Empregado.ContEmpregados); // 1
        var empregado2 = new Empregado("Ana");
        Console.WriteLine(Empregado.ContEmpregados); // 2
        
    }
}