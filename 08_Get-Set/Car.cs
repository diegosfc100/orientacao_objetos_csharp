class Car
 {
    private int speed; // Atributo privado

    public Car(int speed) // Construtor
    {
        Speed = speed;
    }
    
    public int Speed // Propriedade - não tem (), diferente dos métodos 
    {
        get { return speed; }
        set 
        { 
            if(value >= 120)
            {
                speed = 120;            
            }
            else
            {
                speed = value;
            } 
        }
    }
}