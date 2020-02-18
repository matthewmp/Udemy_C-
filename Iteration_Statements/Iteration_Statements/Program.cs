using System;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // For loop
            for(byte i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for(byte i = 0; i <=10; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine("{0} is an even number", i);
                }
            }

            // For Each Loop
            string name = "John Smith";
            foreach(char character in name){
                Console.WriteLine(character);
            }

            // For Each with Arrays
            int[] numbers = new int[] {1,2,3,4,5};
            foreach(byte num in numbers){
                Console.WriteLine(num);
            }


            // WHILE LOOPS
            byte j = 0;
            while(j <= 10){
                if(j % 2 == 0){
                    Console.WriteLine(j);
                }
                j++;
            }

            Console.WriteLine("");
            Console.WriteLine("");

            // While Loop with "break" statement
            while(true){
                Console.WriteLine("Enter your name: ");
                string input = Console.ReadLine();

                if(String.IsNullOrWhiteSpace(input)){
                    break;
                }

                Console.WriteLine("@Echo {0}", input);
            }

            // While Loop with "continue" statement
            // When program encounters "continue" it will 
            //  return to the beginning of the while loop

            while(true){
                Console.WriteLine("Enter you name: ");
                string input2 = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(input2)){
                    Console.WriteLine("@Echo {0}", input2);
                    continue;
                }
                break;
            }

        }
    }
}
