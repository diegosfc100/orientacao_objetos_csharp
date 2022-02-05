// INTERFACE
// Utilizada para criar exclusivamente métodos obrigatórios;
// Uma classe pode implementar várias Interfaces;
// Os métodos da Interface não contêm cálculos, condicionais, laços e demais ações, qm faz isso é classe q implementa a Interface.
// Ex: double calculo(double numero);
// Por padrão método criado na Interface é abstrato e público. ( public abstract já vem por padrão);
// Toda interface tem a inicial 'I' em seguida o nome da Interface.

interface IPadrao
{
    void somar(int n1, int n2);

    void subtrair(int n1, int n2);
}