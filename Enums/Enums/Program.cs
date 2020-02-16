using System;

namespace Enums
{
    // A data type that represents a name value pairs or constants
    // If you have more than one realted constants, instead of having the declared separately,
    // Across your code you can group them into a new type that groups them together

    // Must be created at the namespace level

    // ie. If you have a mailing service (shopping) app that takes in 3 different types of shipping options,
    // USPS, UPS, FedEx.  Instead of giving each one of them values ie.
    // const int USPS = 1;
    // const int UPS = 2;
    // const int FedEx = 3;

    // You can group them into an "enum" ie.
    /*

    public enum ShippingMethod : byte // This is optional and will set the type for all enums, default type is int
    {
        USPS = 1,
        UPS = 2,
        FedEx = 3;
    }


    Now that the above enum is created you can use 'dot' notation to get the various values ie.
    var method = ShippingMethod.FedEx

     */

    public enum ShippingMethod
    {
       RegularMail = 1,
       RegisteredAirMail = 2,
       Express = 3
    }

    // If values are not assigned as above (1,2,3), the enum will have a sequential int value starting from 0 ie.
    /* RegularMail,
       RegisteredAirMail,
       Express

        The above wil have the following values: 0,1,2
     */

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); // If not casted to int the Console method will cast the shipping method as a string: "Express"

            // If you receive a number for a shipping method from another part of the application you can cast
            // that numerical value into a shipping method ie.

            const byte methodID = 2;
            Console.WriteLine((ShippingMethod)methodID);

            // You can convert an enum to a string
            // Every object in C# has a .ToString method, you can explicitly cast the method to a string ie.
            Console.WriteLine(method.ToString());

            // You can also convert (parse) a string to an enum ie.
            var methodName = "RegularMail";
            var shippingMeth = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMeth);
        }
    }
}
