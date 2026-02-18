using System;

namespace Tasks2
{
    // 2.1
    class Student
    {
        public Student()
        {
            Console.WriteLine("Student created");
        }
    }

    // 2.2
    class Child
    {
        public Child()
        {
            Console.WriteLine("Child created");
        }
    }

    // 2.3
    class CarYear
    {
        public int year;

        public CarYear(int year)
        {
            this.year = year;
        }
    }

    // 2.4
    class Car
    {
        public string name;
        public string color;

        public Car(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
    }

    // 2.5
    class Product
    {
        protected string name;

        // Конструктор копирования
        public Product(Product other)
        {
            this.name = other.name;
        }

        public Product(string name)
        {
            this.name = name;
        }
    }

    // 2.6
    class Person
    {
        private int age;

        public Person() // стандартный конструктор
        {
            age = 18;
        }

        public void Print()
        {
            Console.WriteLine("Age: " + age);
        }
    }

    // 2.7
    class Manager
    {
        private int age;
        private string name;

        public Manager(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        // Конструктор копирования
        public Manager(Manager other)
        {
            this.age = other.age;
            this.name = other.name;
        }

        public void Print()
        {
            Console.WriteLine("Name: " + name + ", Age: " + age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2.1
            Student student = new Student();

            // 2.2
            Child child1 = new Child();
            Child child2 = new Child();

            // 2.3
            CarYear car1 = new CarYear(2022);
            Console.WriteLine("Car year: " + car1.year);

            // 2.4
            Car lada = new Car("LADA VESTA", "black");
            Car bmw = new Car("BMW X5", "white");

            Console.WriteLine($"{lada.name} - {lada.color}");
            Console.WriteLine($"{bmw.name} - {bmw.color}");

            // 2.5
            Product product1 = new Product("Phone");
            Product product2 = new Product(product1);

            // 2.6
            Person person = new Person();
            person.Print();

            // 2.7
            Manager manager1 = new Manager(20, "Дамир");
            Manager manager2 = new Manager(18, "Сара");

            manager1.Print();
            manager2.Print();
        }
    }
}
