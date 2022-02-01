using System;

class Program
{
    static void Main(string[] args)
    {
        Product obj = new Product();
        Console.WriteLine("Digite o nome do Produto: ");
        obj.Name = Console.ReadLine();
        

        Console.WriteLine("Digite o valor do produto: ");
        obj.Value = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine($"Nome do Produto: {obj.Name} ; Valor do Produto: {obj.Value}");
        
    }
}