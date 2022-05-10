using Introduction_to_OOP_Birds.Models;

    class Program
    {
        private static void Main()
        {
            Console.WriteLine("\n Welcome to the Bird Program!\n");
            Console.WriteLine("****Parrot Class**** \n ->");
            Parrot myParrot = new ("Budgie","Green");
            myParrot.Speak();
            
            Console.WriteLine("\n ****Pigeon Class**** \n ->");
            Pigeon myPigeon = new ("Angel","Black");
            Console.WriteLine("{0} is a {1} Pigeon",myPigeon.GetName(),myPigeon.GetColor());
            myPigeon.Speak();
            myPigeon.EatPizza();
            myPigeon.Spin();
            myPigeon.DoTheCaterpillar();
            myPigeon.Jump();
            myPigeon.Sleep();
            
            Console.WriteLine("\n ****Penguin Class**** \n ->");
            Penguin myPenguin = new ("Kiwi","White");
            Console.WriteLine("{0} is a {1} Penguin",myPenguin.GetName(),myPenguin.GetColor());
            myPenguin.Speak();
            myPenguin.Fly();
            myPenguin.Spin();
            myPenguin.DoTheCaterpillar();
            myPenguin.Jump();
        }
    }
