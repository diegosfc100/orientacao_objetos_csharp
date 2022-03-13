class Program
{
    static void Main(string[] args)
    {
        Carro carro1 = new Carro();     
        //carro1.Nome = "BMW";  // GET
        //Console.WriteLine("Nome do carro: {0}", carro1.Nome); // SET

        Car car = new Car(30000);        
        Console.WriteLine("Vc está numa velocidade de: {0}Km/H", car.Speed);       
    } 
}
