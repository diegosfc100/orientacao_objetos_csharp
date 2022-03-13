// GET , SET
    // Os Getters e Setters vêm para prover essa funcionalidade. Através de um método get podemos gerenciar a forma com que um atributo é apresentado fora de seu escopo
    // Responsáveis pelo gerenciamento sobre o acesso aos atributos. Esse método determina quando será alterado um atributo e o acesso ao mesmo.
    // Get: captura o valor de um atributo; Leitura.
    // Set: envia/stribui o valor para um atributo; Escrita.

    /* GET significa obter, pegar, conseguir. Ou seja, esse método vai pegar coisas pra gente.
    Ele vai pegar os valores das propriedades pra gente. Então, ao invés de acessar diretamente uma propriedade,
    podemos setar a propriedade como privada, e usar o GET pra retornar o valor da propriedade.
    Imagine que você está num banco (sem caixas eletrônicos e que armazena o dinheiro num cofre) e você deseja 
    verificar o saldo da sua conta bancária. Você verifica diretamente dentro do cofre o seu saldo, ou
    você pede para um funcionário do banco ir lá no cofre e verificar o saldo da sua conta?
    Não é muito mais seguro a segunda opção? Esse é um dos principais motivos de usar o getter
    (além de que nós podemos fazer validações na hora de retornar o valor pro usuário). */
    
    /* SET é mais ou menos como o oposto do GET. Se o GET retornava o valor pra gente,
    o SET vai gravar o valor que nós passarmos pra dentro da propriedade da classe desejada.
    Ele tem os mesmo benefícios dos getters citados acima. */

class Carro
{         
    private string nome;

    // Get Set
    public string Nome
    {
        // não é obrigatório utilizar os dois, pode ser um deles ou ambos.
        get{return nome;}
        set{nome = value;}
    }

    public Carro() // Construtor
    {
        nome = "Ferrari";
    }
   
    // prop + tab >>> public string Nome { get; set; }
    // propfull + tab >>>
    /*
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
    */
    

}