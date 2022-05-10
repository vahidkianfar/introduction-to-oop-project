﻿namespace Introduction_to_OOP_Birds.Models;


public abstract class Bird:IDance
{
    protected Bird(string name, string color)
    {
        Name = name;
        Color = color;
    }
    private string Name { get; set; }
    private string Color { get; set; }
    
    //I can use "public" instead of "protected" for SetName and SetColor
    //if I want to change Name and Color of the instances.
    protected void SetName(string name) => Name = name; 
    protected void SetColor(string color) => Color = color;
    public string GetName() => Name;
    public string GetColor() => Color;
    public virtual void Fly()
    {
        Console.WriteLine("I am {0} a Bird and I am flying!", GetName());
    }

    public abstract void Speak();
    
    
    public void Spin()
    {
        Console.WriteLine("{0} is dancing!", GetName());
    }

    public void DoTheCaterpillar()
    {
        Console.WriteLine("{0} is doing the caterpillar!",GetName());
    }

    public void Jump()
    {
        Console.WriteLine("{0} is jumping!",GetName());
    }
}