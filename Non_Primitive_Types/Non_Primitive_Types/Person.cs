using System;

namespace Non_Primitive_Types
{
    // Create classes at the name space level which is here
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
