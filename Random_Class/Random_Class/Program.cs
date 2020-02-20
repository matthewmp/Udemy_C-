using System;

namespace Random_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instatiate random class
            var random = new Random();
            for (byte i = 0; i < 10; i++)
                // Random.Next() generates random integer
                // Can pass max value
                Console.WriteLine(random.Next(10));

            Console.WriteLine();
            Console.WriteLine("Press enter to continue and generate 10 random #'s between 7-10");
            Console.ReadLine();
            Console.Clear();

            // Can pass 2 arguments for Min/Max
            for (byte i = 0; i < 10; i++)
            {
                Console.WriteLine("Genreating Random # Between 7-10, {0}", random.Next(7, 10));
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue and generate 10 random characters by casting random #s to ascii");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Genreating Random string:");
            for (byte i = 0; i < 10; i++)
            {
                Console.Write((char)random.Next(97, 122));
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to generate 10 random characters by casting random #s to ascii");
            Console.ReadLine();
            Console.Clear();

            // Improved method for above (generating random charcter)
            Console.WriteLine("Genreating Random string:");
            for (byte i = 0; i < 10; i++)
            {
                // Generate random # between 0-26 for letters of alphabet
                // Add 'a' to it which is a number
                // Cast new numbrer value to char
                Console.Write((char)('a' + random.Next(0, 26)));
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to generate 10 random characters by casting random #s to ascii");
            Console.ReadLine();
            Console.Clear();

            // Because strings are immutable you can use arrays of chars to manipulate them if needed
            // Below does same as above using a char array and converts it to a string
            const int rdmStrLength = 10;
            char[] buffer = new char[rdmStrLength];
            for (byte i = 0; i < rdmStrLength; i++)
            {
                buffer[i] = (char)random.Next(97, 122);
            }

            string randomStr = new string(buffer);
            Console.WriteLine(randomStr);



        }
    }
}
