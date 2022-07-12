using System;

class Exemplo
{
    // Método Estático
    // Só pode acessar atributos ou metodos q tbm sejam estáticos
    // Muito utilizado p/ classes com métodos utilitários. Ex: Math
    // Adicionando 'static' ao método, passamos a ter acesso ao método sem precisar instanciar o objeto.
    public static void soma(int n1, int n2)
    {
        Console.WriteLine(n1 + n2);
    }

    // Atributo Estático
    public static string nome = "Diego Rodrigues";
}