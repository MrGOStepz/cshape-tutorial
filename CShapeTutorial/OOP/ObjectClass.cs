using System;
using System.ComponentModel;

namespace CShapeTutorial.OOP
{
    internal class ObjectClass
    {
        public void Test()
        {
            // Create a new object of type Vehicle.
            // Create an instance of the Vehicle class and store it in a variable called audi.      
            // Vehicle audi = new Vehicle();
            Vehicle audi = new Vehicle("A4", "Audi");
            audi.Print(message: "Hello Audi", repeat: 3);
            Vehicle.MyMethod();
        }

        public class Vehicle
        {
            private static int nextId = 0;
            // Read only variable is a variable that cannot be changed after it is initialized.
            private readonly int _id;
            //Read only property
            // public int Id => _id;
            public int Id
            {
                get => _id;
            }
            //Write only property
            // public void SetId(int id)
            // {
            //     _id = id;
            // }

            
            // const vs readonly
            private const int MAX_SPEED = 200;
            
            
            // Class is a blueprint for creating objects, encapsulating data and behavior.
            // Action can call function, member variable, member function, etc.
            // Inherits from another class.
            private string _model; // member variable, property
            private string _brand;


            // public private protected
            // public can access from anywhere
            // private can only access from inside the class
            // protected can only access from inside the class or derived classes.

            // Property
            public int Amount { get; set; }

            // Property with Lamba Expression
            public string Model
            {
                get => _model;
                set => _model = value;
            }

            // Auto Property
            public string Brand
            {
                get { return _brand; }

                set { _brand = value; }
            }

            // Constructor is a special method that is called when an object of a class is created.
            // It is used to initialize member variables.
            // The name of Constructor is the same as the name of the class.
            // ctor is short for constructor.
            public Vehicle()
            {
            }

            public Vehicle(string model, string brand)
            {
                _id = nextId++;
                Model = model;
                Brand = brand;
            }

            // Default Parameter
            public void Print(string message = "Hello World!")
            {
                Console.WriteLine(message);
            }

            // Named Parameter
            public void Print(string message, int repeat)
            {
            }

            // Method
            public void Drive()
            {
                // cw Tap
                Console.WriteLine($"Driving {Brand} {Model}");
            }


            //Static Variable
            public static int Number { get; set; }

            // Static Method 
            public static void MyMethod()
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}