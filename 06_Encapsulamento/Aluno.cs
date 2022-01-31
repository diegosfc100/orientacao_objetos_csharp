using System;

// ENCAPSULAMENTO
// Conceito de Encapsulamento: Restringir acesso/visibilidade às informações contidas nas classes
// Ex: Numa capsula de remedio por exemplo, a gente sabe q contém remedio ali dentro mas a gente não tem contato direto com ele devido estar encapsulado.
class Aluno
{
    private double nota1, nota2;

    private double media()
    {
        return(nota1 + nota2) / 2;
    }

    public void mensagem()
    {
        Console.WriteLine("Informe a primeira nota: ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"A média é: {media()}");
    }
}

// Conceito de Encapsulamento: Restringir acesso/visibilidade às informações contidas nas classes
// Numa capsula de remedio por exemplo, a gente sabe q contém remedio ali dentro mas a gente não tem contato direto com ele devido estar encapsulado, 