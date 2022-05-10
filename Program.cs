using Introduction_to_OOP_Birds.Models;

    class Program
    {
        private static void Main()
        {
            Console.WriteLine("\n Welcome to the Bird Program!\n");
            Console.WriteLine("****Parrot Class**** \n ->");
            var myParrot = new Parrot("Budgie","Green");
            myParrot.Speak();
            
            Console.WriteLine("\n ****Pigeon Class**** \n ->");
            var myPigeon = new Pigeon("Angel","Black");
            Console.WriteLine("{0} is a {1} Pigeon",myPigeon.GetName(),myPigeon.GetColor());
            myPigeon.Speak();
            myPigeon.EatPizza();
            myPigeon.Spin();
            myPigeon.DoTheCaterpillar();
            myPigeon.Jump();
            myPigeon.Sleep();
            
            Console.WriteLine("\n ****Penguin Class**** \n ->");
            var myPenguin = new Penguin("Kiwi","White");
            Console.WriteLine("{0} is a {1} Penguin",myPenguin.GetName(),myPenguin.GetColor());
            myPenguin.Speak();
            myPenguin.Fly();
            myPenguin.Spin();
            myPenguin.DoTheCaterpillar();
            myPenguin.Jump();
        }
    }
