using System;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args) 
        {
            ContaCorrente conta = new ContaCorrente(); // instanciando objeto

            // acessando os atributos p/ atribuir
            conta.titular = "Diego Rodrigues";
            conta.numAgencia = 1546;
            conta.numConta = "0015407-0"; 
            conta.saldo = 90_500.50;
            
            // acessando os atributos p/ exibir
            Console.WriteLine($"Titular da Conta: {conta.titular}");
            Console.WriteLine($"Agência: {conta.numAgencia}");
            Console.WriteLine($"Número da Conta: {conta.numConta}");
            Console.WriteLine($"Saldo: {conta.saldo.ToString("C2")}");

            // acessar p/ modificar
            conta.saldo += 5000;
            Console.WriteLine($"Saldo Atualizado: {conta.saldo.ToString("C2")}");

        }

        
    }
}