class Pessoa
{
    private string nome = "José";

    public Pessoa(string nome)
    {
        Console.WriteLine(nome); // 'nome' = parâmetro, caso nao houvesse parametro, o programa entenderia q 'nome' é o atributo
        Console.WriteLine(this.nome); // This remete ao atributo
        
    }
}