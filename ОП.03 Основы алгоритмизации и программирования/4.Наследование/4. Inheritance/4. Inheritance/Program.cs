using System;

namespace Tasks4
{
    // 4.1
    class Person
    {
        public string Name { get; set; }
    }

    class Student : Person
    {
        public string University { get; set; }
    }

    // 4.2
    class Animal
    {
        public string Species { get; set; }
    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meow");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woof");
        }
    }

    // 4.3
    class Entity
    {
        public int Id { get; set; }
    }

    class Product : Entity
    {
        public string Name { get; set; }
    }

    // 4.4
    class Dishes
    {
        public string Material { get; set; }
    }

    class Cup : Dishes
    {
        public int Volume { get; set; }
    }

    // 4.5
    class Staff : Entity
    {
        public string Position { get; set; }
    }

    class Manager : Staff
    {
        public string Department { get; set; }
    }

    // 4.6
    class AnimalBase
    {
        protected int age; // доступен в AnimalBase и Predator

        public AnimalBase(int age)
        {
            this.age = age;
        }
    }

    class Predator : AnimalBase
    {
        public Predator(int age) : base(age)
        {
        }

        public void ShowAge()
        {
            Console.WriteLine("Age: " + age);
        }
    }

    // 4.7
    class Transport
    {
        protected string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }

    class SpaceShuttle : Transport
    {
        public void Show()
        {
            Console.WriteLine("Space Shuttle: " + name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 4.1
            Student student = new Student { Name = "Рина", University = "КМБ" };
            Console.WriteLine(student.Name + " - " + student.University);

            // 4.2
            Cat cat = new Cat();
            cat.Meow();

            Dog dog = new Dog();
            dog.Bark();

            // 4.6
            Predator predator = new Predator(5);
            predator.ShowAge();

            // 4.7
            SpaceShuttle shuttle = new SpaceShuttle();
            shuttle.SetName("Discovery");
            shuttle.Show();
        }
    }
}
