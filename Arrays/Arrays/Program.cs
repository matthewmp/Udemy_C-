using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3]; // Must specify length of array
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]); // Set to default value of integers (0)
            Console.WriteLine(numbers[2]); // Set to default value of integers (0)

            bool[] flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]); // Set to default value of boolean (false)
            Console.WriteLine(flags[2]); // Set to default value of boolean (false)

            string[] names = new string[3] {"Jack", "John", "Mary"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

        }
    }
}
