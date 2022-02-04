using System;

class Exemplo
{
    // Método Estático
    // Adicionando 'static' ao método, passamos a ter acesso ao método sem precisar instaciar o objeto.
    public static void soma(int n1, int n2)
    {
         Console.WriteLine(n1 * n2);
    }

    // Atributo Estático
    public static string nome = "Diego Rodrigues";
}