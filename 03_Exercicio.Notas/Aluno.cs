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
    public string situacao(double media)
    {
        return media >= 7 ? "APROVADO" : "Reprovado";
    }

    // Métodos - Mensagem
    public void mensagem()
    {
        double obterMedia = media();
        string obterSituacao = situacao(obterMedia);
        Console.WriteLine($"Aluno {nome}, você está {obterSituacao} com média de {obterMedia}.");

    }
    
}
