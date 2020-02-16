using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings are surrounded by "" where characters are surrounded by ''

            // String literal
            string firstName = "Matt";
            string lastName = "Palumbo";
            // Concatenate with +
            string name = firstName + " " + lastName;

            Console.WriteLine(name);

            // String formats
            string name2 = string.Format("{0} is my first name and {1} is my last name", firstName, lastName);

            Console.WriteLine(name2);

            // Joining elements of an array into a string
            int[] numbers = new int[3] { 1, 2, 3 };

            string list = string.Join(",", numbers);
            Console.WriteLine(list);

            // Get character in string
            Console.WriteLine(list[2]);

            // ===! Strings are immutable

            /* === Escape Characters
             *  \n New Line
             *  \t Tab
             *  \\ BackSlash
             *  \' Single Quote
             *  \" Double Quote

             */

            // Verbatim Strings are a way to type strings without the need of escape characters.
            // For example if you wanted to make a string for a path on a Windows machine i.e
            string path1 = "c:\\projects\\project1\\folder1";
            Console.WriteLine(path1);
            // You can get the same result without escape characters by using Verbatim String by preceding with an "@" character
            string path2 = @"c:\projects\project1\folder1";
            Console.WriteLine(path2);
            // Another Verbatim example
            string verbatimExample = @"First line,
Second line
etc.";
            Console.WriteLine(verbatimExample);

            // All primitive types are related to a .NET type ie. string is related to the String class in the System namespace
            // There for you can create a string either by declaring it:
            string str1 = "First String";
            // or by using the .NET System Class String
            String str2 = "Second String";
            Console.WriteLine("{0} : {1}", str1, str2);



}
}
}
