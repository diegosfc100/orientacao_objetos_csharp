class Colaborador : Pessoa // Herança 
{
    // Atributo
    private double salario;

    // Construtor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        this.mensagemPessoa();
        this.mensagemColaborador();        
    }

    // Método
    private void mensagemColaborador()
    {
        Console.WriteLine($"Salário: ${salario}");
    }
}