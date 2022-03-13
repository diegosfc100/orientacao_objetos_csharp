using System;

// ABSTRAÇÃO
// É uma classe q pode conter métodos obrigatórios para todas as classes q a herdarem;
// É possível criar métodos convencionais para q as classes q herdem consigam utilizar;
// Não é possível instanciar uma clase abstrata. ex: Prod prod = new Prod();
// Cada classe pod eherdar apenas UMA classe abstrata.
// Qdo se cria uma classe abstrata, ela passa a ser um padrão.
abstract class Padrao
{
    // Método obrigatório (public ou protected)
        public abstract void taxaEmprestimo(double valor); // public void nome(tipo parametro) SÃO OBRIGATÓRIOS.


    // Método opcional
        public void calculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine($"Ganhos obtidos pela poupança ${valor * taxa}");
        }
}