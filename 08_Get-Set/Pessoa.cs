class Pessoa
{
    // GET SET
    // Get: pega o valor ; Set: envia o valor para um atributo
    
    private string nome; // Nesse caso, devido o acesso ser private, somente a classe Pessoa tera acesso ao tributo 'nome';

    // Get Set
    public string Nome
    {
        // não é obrigatório utilizar os dois, pode ser um deles ou ambos.
        get{return nome;}
        set{nome = value;}
    }

    // Forma simplificada
    // public string Nome { get; set; }
    // digite: prop + tab

}