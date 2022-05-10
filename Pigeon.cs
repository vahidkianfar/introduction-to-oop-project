namespace Introduction_to_OOP_Birds;

public class Pigeon : Bird
{
    public Pigeon(string name, string color) : base(name, color)
    {
        SetName(name);
        SetColor(color);
    }
    public override void Speak()
    {
        Console.WriteLine("I am {0} a pigeon, I can't speak", GetName());
    }
    public void EatPizza()
    {
        Console.WriteLine("I am {0} a pigeon and I can eat Pizza, Woow" ,GetName());
    }
}