namespace Introduction_to_OOP_Birds;

public class Penguin: Bird
{
    public Penguin(string name, string color) : base(name, color)
    {
        SetName(name);
        SetColor(color);
    }
    
    //if I want to use the base class Speak()/Fly() method -->
    //***public void Speak()/Fly() => base.Speak()/base.Fly();***
    //Or i can simply not implemented in the Penguin class (But I guess we want Polymorphism)
    public override void Speak()
    {
        Console.WriteLine("I'm {0} a penguin, I am Speaking! hmmm weird!", GetName());
    }
    public override void Fly()
    {
        Console.WriteLine("I'm {0} a penguin, I can't fly!", GetName());
    }
}