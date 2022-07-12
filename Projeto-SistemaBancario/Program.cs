using System;

namespace SistemaBancario
{
    class Program
    {
        static void Main(string[] args) 
        {
            ContaCorrente conta = new ContaCorrente();
          //string agencia = "1125-4";
            conta.DefinirAgencia("1125-4");
            conta.numConta = "15447-4";
            conta.saldo = 200;

            Cliente cliente = new Cliente();
            cliente.nome = "Diego Rodrigues";
            cliente.cpf = "392.982.438-70";
            cliente.telefone = "11 96867-7255";

            Console.WriteLine($"Agência número: {conta.ObterAgencia()}");

            // Associando a conta ao cliente
            conta.titular = cliente;


            // Forma alternativa de criar objeto
            Cliente cliente2 = new Cliente
            {
                nome = "Andreia dos Santos",
                cpf = "372.702.388.85",
                telefone = "11 96885-1126"
            };

            ContaCorrente conta2 = new ContaCorrente
            {
                titular = cliente2,
                //numAgencia = 4493, >> agora q naõ tenho mais o atributo agencia como public, como definir ?
                numConta = "11235-7",
                saldo = 300
            };

        }        
    }
}