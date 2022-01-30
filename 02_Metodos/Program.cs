using System;

namespace _02_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();
            obj.apresentar();
            obj.apresentar("Diego");
            obj.apresentar("Diego", 31);
        }
    }
}