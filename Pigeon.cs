namespace Introduction_to_OOP_Birds;

public class Pigeon : Bird
{
    public Pigeon(string name, string color) : base(name, color)
    {
        SetName(name);
        SetColor(color);
    }
    //public void speak() => base.speak(); <---- if I want to use the base class speak method
    //Or i can simply not implemented in the Penguin class (But I guess we want Polymorphism)
    public override void Speak() => Console.WriteLine("I am {0} a pigeon, I can't speak", GetName());
    public void EatPizza() => Console.WriteLine("I am {0} a pigeon and I can eat Pizza, woow" ,GetName());
}