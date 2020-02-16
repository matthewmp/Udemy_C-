using System;
using Non_Primitive_Types.Math;

namespace Non_Primitive_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
        }
    }
}
