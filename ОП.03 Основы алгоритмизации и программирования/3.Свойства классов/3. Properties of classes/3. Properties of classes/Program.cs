using System;

namespace Tasks3
{
    // 3.1
    class Student
    {
        public string Name { get; set; }
    }

    // 3.2
    class Child
    {
        public int Age { get; set; }

        public Child()
        {
        }
    }

    // 3.3
    class CarYear
    {
        private int year;

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 0)
                    year = value;
            }
        }

        public CarYear()
        {
        }
    }

    // 3.4
    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Car()
        {
        }
    }

    // 3.5
    class Product
    {
        protected string name;

        public string Name
        {
            get { return name; }
        }

        public Product()
        {
            name = "Рамиль";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 3.1
            Student student = new Student();
            student.Name = "Рина";
            Console.WriteLine(student.Name);

            // 3.2
            Child child1 = new Child { Age = 5 };
            Child child2 = new Child { Age = 8 };

            Console.WriteLine("Child1 Age: " + child1.Age);
            Console.WriteLine("Child2 Age: " + child2.Age);

            // 3.3
            CarYear carYear = new CarYear();
            carYear.Year = 2023;
            Console.WriteLine("Car Year: " + carYear.Year);

            // 3.4
            Car car = new Car
            {
                Name = "KIA SOUL",
                Color = "green"
            };

            Console.WriteLine($"{car.Name} - {car.Color}");

            // 3.5
            Product product = new Product();
            Console.WriteLine("Product Name: " + product.Name);
        }
    }
}

