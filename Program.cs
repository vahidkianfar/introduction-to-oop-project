namespace Introduction_to_OOP_Birds;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n Welcome to the Bird Program!\n");
            Console.WriteLine("****Pigeon Class**** \n ->");
            var pigeon = new Pigeon("Angel","Black");
            Console.WriteLine("{0} is a {1} Pigeon",pigeon.GetName(),pigeon.GetColor());
            pigeon.Speak();
            pigeon.EatPizza();
            pigeon.Spin();
            pigeon.DoTheCaterpillar();
            pigeon.Jump();

            Console.WriteLine();
            
            Console.WriteLine("****Penguin Class**** \n ->");
            var penguin = new Penguin("Kiwi","White");
            Console.WriteLine("{0} is a {1} Penguin",penguin.GetName(),penguin.GetColor());
            penguin.Speak();
            penguin.Fly();
            penguin.Spin();
            penguin.DoTheCaterpillar();
            penguin.Jump();
            
            /* Because the Bird class is Abstract we cannot create an instance of it.
                * We can only create an instance of the subclass.
             
            Console.WriteLine("****Bird Class**** \n ->");
            var bird = new Bird("Coco","Blue");
            Console.WriteLine("{0} is {1}",bird.getName(),bird.getColor());
            bird.fly();
            bird.speak();
            bird.jump();
            bird.doTheCaterpillar();
            bird.spin();
            Console.WriteLine();*/
        }
    }
