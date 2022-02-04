using System; 
// using é usada p/ importar Funcionalidades; 
// System é uma biblioteca padrão, usada para exibir e armazenar dados através do console;

namespace _01_Conceitos // Local / Diretório do projeto
{

    class Program
    {

        static void Main(string[] args) // Todo projeto deve ter UM metodo 'static void Main'
        {

            // Instanciar um objeto ; Criar algo a partir de um molde
            Pessoa obj = new Pessoa();
            obj.Nome = "João";
            obj.Idade = 99;
            obj.Mensagem();



        }
    }
}