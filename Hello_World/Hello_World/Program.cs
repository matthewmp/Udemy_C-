using System;
using System.IO;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            byte numTest = 255;

            TextReader txtInp = Console.In;
            Console.Write("Enter Your name: ");

            String name = txtInp.ReadLine();

            // Prevents an overflow.  Since a byte can only store up to 255 adding 1 to it will cause it to overflow and make value 0;
            // Using the "checked" code block below will throw an error instead of letting the value to overflow

            //checked
            //{
                //numTest += 1;
            //}
            
            Console.WriteLine("Hello {0} the console title is {1}", name, numTest);


            // Similar to JS C3 has a lexical scope.  The inner most code block can acces num1, num2, num3 but not vice/versa
            {
                byte num1 = 1;
                {
                    byte num2 = 2;
                    Console.Write("Num1 is: {0}, Num2 is: {1}", num1, num2);
                    {
                        byte num3 = 3;
                        Console.Write("Num 1 is: {0}, Num2 is: {1}, Num3 is: {2}", num1, num2, num3);
                    }
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Byte: {0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("Int: {0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("Float: {0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Long: {0} {1},", long.MinValue, long.MaxValue);

            // Casting
            int n1 = 255;
            byte b1 = (byte)n1;
            Console.WriteLine("b1: {0}", b1);
            Console.WriteLine(Convert.ToString(b1, 2));


            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception e1)
            {
                Console.WriteLine("Number could not be converted to a byte.  See below for error:");
                //Console.WriteLine(e1);
            }
        }
    }
}
