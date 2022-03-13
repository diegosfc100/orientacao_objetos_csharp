class Pessoa
{
    private string cor = "Azul";

    public Pessoa(string cor)
    {
        Console.WriteLine(cor); // 'nome' = parâmetro, caso nao houvesse parametro, o programa entenderia q 'nome' é o atributo
        Console.WriteLine(this.cor); // This remete ao atributo
        
        // ESSA.cor RECEBE cor
    }
}