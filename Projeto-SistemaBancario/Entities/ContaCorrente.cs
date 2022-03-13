using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaBancario
{
    public class ContaCorrente
    {
        public string titular;
        public int numAgencia;
        public string numConta;
        public double saldo = 100; // atributo com valor padrão

        public void Depositar(double valor)
        {   
            saldo += valor; 
        }

        public bool Sacar(double valor)
        {
            if(valor >= saldo)
            {
            return false;
            }     

            saldo -= valor;
            return true;            
        }


    }
}