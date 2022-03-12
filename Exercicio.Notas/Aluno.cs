using System; // System dá acesso p exibir msg no terminal.

class Aluno
{
    // Atributos
    public string nome;
    public double nota1, nota2;

    // Método - Média
    public double media()
    {
        return (nota1 + nota2) / 2;
    }

    // Método - Situação
    // Quando um método tem retorno, ele pode ser armazenado numa variável, 
    // ou ser utilizado como parametro por outro método.
    public string situacao(double media)
    {
        return media >= 7 ? "APROVADO" : "Reprovado";
    }

    // Métodos - Mensagem
    // Variaveis podem obter dados através de métodos, ou seja, ter métodos como valor.    
    public void mensagem()
    {
        double obterMedia = media();
        string obterSituacao = situacao(obterMedia);
        
        Console.WriteLine($"Aluno {nome}, você está {obterSituacao} com média de {obterMedia}.");

    }
    
}
