using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    public class ContaCorrente
    {
        public Cliente titular; // Titular deixou de ser string e passou a ser um Objeto do tipo Cliente.
        private string numAgencia; // modificador de acesso private
        public string numConta;
        public double saldo = 100; // atributo com valor padrão

        public void DefinirAgencia(string ag) // para inserir valores dentro de atributos usamos os Métodos
        {
            if (ag.Length != 6 || !ag.Contains('-'))
            {   
                return;
            }

            numAgencia = ag;
        }

        public string ObterAgencia()
        {
            return numAgencia;
        }

        public void Depositar(double valor)
        {   
            saldo += valor; 
        }

        public bool Sacar(double valor)
        {
            if(valor > saldo)
            {
            return false;
            }     

            saldo -= valor;
            return true;            
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
           if(valor > saldo)
           {
               return false;
           }

            saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

    }
}