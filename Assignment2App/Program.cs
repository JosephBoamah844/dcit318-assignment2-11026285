﻿using Assignment2App.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a task:");
        Console.WriteLine("1. Inheritance and Method Overriding");
        Console.WriteLine("2. Abstract Classes and Methods");
        Console.WriteLine("3. Interfaces");
        Console.Write("Enter choice: ");
        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Animal genericAnimal = new Animal();
                Animal dog = new Dog();
                Animal cat = new Cat();
                genericAnimal.MakeSound();
                dog.MakeSound();
                cat.MakeSound();
                break;

            case "2":
                Shape circle = new Circle(5);
                Shape rectangle = new Rectangle(4, 6);
                Console.WriteLine($"Circle area: {circle.GetArea()}");
                Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
                break;

            case "3":
                IMovable car = new Car();
                IMovable bicycle = new Bicycle();
                car.Move();
                bicycle.Move();
                break;

            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
