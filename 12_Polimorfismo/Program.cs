class Program
{
    static void Main(string[] args)
    {
        // Instanciar Estagiário
        Imposto objetoE = new Estagiario(); 
        // Imposto objetoE ~> ( objetoE terá acesso aos métodos da classe Imposto.)
        // new Estagiario() ~> ( se a classe Estagiário tiver algum método em comum com a classe Imposto, ele irá sobrescrever.)
        objetoE.valeAlimentacao(1000);
        objetoE.valeTransporte(1000);
        Console.WriteLine();

        // Instanciar Gerente
        Imposto objetoG = new Gerente();
        objetoG.valeAlimentacao(10000);
        objetoG.valeTransporte(10000);
        Console.WriteLine();

        // Instanciar Atendente
        Imposto objetoA = new Atendente();
        objetoA.valeAlimentacao(500);
        objetoA.valeTransporte(500);
        Console.WriteLine();
    }
}