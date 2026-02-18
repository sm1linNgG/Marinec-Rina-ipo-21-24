using System;

namespace Tasks
{
    // 1.1
    class Student
    {
        public string name;
    }

    // 1.2
    class Car
    {
        public int year;
    }

    // 1.3
    class Point
    {
        public int x;
    }

    // 1.4
    class Person
    {
        public int age;

        public void Print()
        {
            Console.WriteLine("Age: " + age);
        }
    }

    // 1.5
    class Table
    {
        public int rows;
        public int cols;

        public void Display()
        {
            Console.WriteLine("Rows: " + rows);
            Console.WriteLine("Cols: " + cols);
        }
    }

    // 1.6
    class Manager
    {
        private int age;
        private string name;

        public Manager(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetName()
        {
            return name;
        }
    }

    // 1.7
    class Point3D
    {
        public int x;
        public int y;
        public int z;

        public void Show()
        {
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            Console.WriteLine("Z: " + z);
        }
    }

    // 1.8
    class Shop
    {
        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string newName)
        {
            name = newName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования некоторых классов

            Person person = new Person();
            person.age = 25;
            person.Print();

            Table table = new Table();
            table.rows = 5;
            table.cols = 3;
            table.Display();

            Manager manager = new Manager(17, "Rina");
            Console.WriteLine("Manager: " + manager.GetName() + ", Age: " + manager.GetAge());

            Point3D point = new Point3D();
            point.x = 1;
            point.y = 2;
            point.z = 3;
            point.Show();

            Shop shop = new Shop();
            shop.SetName("My Shop");
            Console.WriteLine("Shop name: " + shop.GetName());
        }
    }
}
