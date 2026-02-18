using System;

namespace Tasks5
{
    // 5.1
    class Strategy
    {
        public virtual void Display()
        {
            Console.WriteLine("Strategy");
        }
    }

    // 5.2
    class Weather
    {
        public virtual void Show()
        {
            Console.WriteLine("My Weather");
        }
    }

    // 5.3
    class ConservativeStrategy : Strategy
    {
        public override void Display()
        {
            Console.WriteLine("Conservative Strategy");
        }
    }

    // 5.4
    class Animal
    {
        private string type;

        public Animal()
        {
            type = "My Type";
        }

        public virtual void Print()
        {
            Console.WriteLine(type);
        }
    }

    class Cat : Animal
    {
        private int age;

        public Cat()
        {
            age = 5;
        }

        public override void Print()
        {
            Console.WriteLine(age);
        }
    }

    // 5.5
    abstract class Entity
    {
        public abstract void Display();
    }

    // 5.6
    class Product : Entity
    {
        public override void Display()
        {
            Console.WriteLine("My Product");
        }
    }

    // 5.7
    interface IPrintable
    {
        void Display();
    }

    class ConsolePrinting : IPrintable
    {
        public void Display()
        {
            Console.WriteLine("My Console");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 5.2
            Weather weather = new Weather();
            weather.Show();

            // 5.3
            Strategy strategy = new Strategy();
            strategy.Display();

            Strategy conservative = new ConservativeStrategy();
            conservative.Display();

            // 5.4
            Animal animal = new Animal();
            Cat cat = new Cat();

            animal.Print();
            cat.Print();

            // 5.6
            Product product = new Product();
            product.Display();

            // 5.7
            ConsolePrinting consolePrinting = new ConsolePrinting();
            consolePrinting.Display();
        }
    }
}
