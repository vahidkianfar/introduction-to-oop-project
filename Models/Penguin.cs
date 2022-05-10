namespace Introduction_to_OOP_Birds.Models;

public class Penguin: Bird
{
    public Penguin(string name, string color) : base(name, color)
    {
        SetName(name);
        SetColor(color);
    }
    public override void Speak()
    {
        Console.WriteLine("I'm {0} a penguin, I am Speaking! hmmm weird!", GetName());
    }
    public override void Fly()
    {
        Console.WriteLine("I'm {0} a penguin, I can't fly!", GetName());
    }
}