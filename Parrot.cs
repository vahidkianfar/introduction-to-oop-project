namespace Introduction_to_OOP_Birds;

public class Parrot:Bird
{
    public Parrot(string name, string color) : base(name, color)
    {
        SetName(name);
        SetColor(color);
    }
    public override void Speak()
    {
        Console.WriteLine("Yo, Yo, Yo {0} In Da House!", GetName());
    }
    
}