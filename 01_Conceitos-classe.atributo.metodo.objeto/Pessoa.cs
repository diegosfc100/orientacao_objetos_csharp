using System; // using é utilizado para importar funcionalidades; System é a biblioteca padrão.

// CLASSE: É como se fosse um molde. (Ex: Pessoa; Veiculo)
// ATRIBUTOS: Caracteríscias. (Ex: nome, idade, peso, sexo/ carro, azul, usado, placa)
// MÉTODOS: São Funções, servem como ações. (Ex: Cumprimentar, Codar, Apresentar-se/  Abastecer; Frear; Buzinar)

class Pessoa
{
    // ATRIBUTOS
    // Ex: toda pessoa tem nome; idade; sexo ...
    // PUBLIC significa q qualqr arquivo.cs terá acesso/visibilidade ao atributo ou método.
    public string nome;
    public int idade;


    // MÉTODOS
    // sempre devem iniciar com letra maíuscula.
    // Void = Nulo (Não retorna nada)
    public void Mensagem() // Métodos sempre iniciam com letra maiuscula
    {
        Console.WriteLine($"Prazer, me chamo {nome} e tenho {idade} anos.");
    }

    // public: significa q qlqr arquivo .cs terá acesso/visualização ao atributo ou método.
    // void: significa q o método não retornará nada, vazio.
}
