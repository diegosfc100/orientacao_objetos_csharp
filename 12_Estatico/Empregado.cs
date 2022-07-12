/* Propriedade e atributos Estáticos normalmente são criados quando
se quer ter um dado compartilhado com TODOS OS OBJETOS DA MESMA CLASSE. */
class Empregado
{
    public string Nome { get; set; }

    public static int ContEmpregados { get; set; }
    // O valor dessa propriedade será compartilhado p todos objetos da class Empregado.

    public Empregado(string nome)
    {
        Nome = nome;
        ContEmpregados++;
    }

}
