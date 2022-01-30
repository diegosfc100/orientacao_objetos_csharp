using System;

class Pessoa
{
    public double peso, altura; // **Atributos do mesmo tipo podem ser declarados juntos.
    
    public double IMC() // **Não precisa de parâmetros nesse caso.
    {
        return peso / (altura * altura);
    }
    public string Situacao(double imc) 
    // Único paramentro q esse método precisa é o imc, q está no método acima.
    // Porém, para não ficar um método dentro de outro, IMC() ficará dentro de uma váriavel e usasei a variável.
    {
        string retorno; 
        // Como uma condicional só pode ter UM return, criei uma variavel e o return irá receber essa váriavel no final.

        if(imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if(imc < 25)
        {
            retorno = "Peso normal";
        }
        else if(imc < 30)
        {
            retorno = "Acima do peso";
        }
        else if(imc < 35)
        {
            retorno = "Obesidade I";
        }
        else if(imc < 40)
        {
            retorno = "Obesidade II";
        }
        else
        {
            retorno = "Obesidade III";
        }

        return retorno;
    }

    public void Mensagem() // **Não precisa de parâmetros nesse caso.
    {
        double imc = IMC();
        // Para não ficar um método dentro de outro, coloquei IMC() dentro de uma variável e chamei ela em seuida.
        string obterSituacao = Situacao(imc);
       
        Console.WriteLine($"Seu IMC atual é {imc} e sua situação é {obterSituacao}");
    }
}