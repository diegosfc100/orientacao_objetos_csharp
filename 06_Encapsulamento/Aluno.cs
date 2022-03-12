using System;

// ENCAPSULAMENTO
// Conceito de Encapsulamento: Restringir acesso/visibilidade às informações contidas nas classes
// Ex: Numa capsula de remedio por exemplo, a gente sabe q contém remedio ali dentro mas a gente não tem contato direto com ele devido estar encapsulado.
// No exemplo abaixo, não e interessante deixar publico o método media() já q só o aluno ira utilizar.
// Em POO o ideal é deixar o máximo possivel de métodos privados.
// Caso a classe tenha atributos e métodos q irão ser instanciados por outras classes, aí sim deve ser public.
class Aluno
{
    private double nota1, nota2;
    
    private double media()
    {
        return(nota1 + nota2) / 2;
    }
    // Por serem atributo e método PRIVADOS, as outras classes não sabem da existencia dele.

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