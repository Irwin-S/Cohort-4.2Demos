using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Declare" (create) a variable using the datatype followed by the name.
            string text; // Strings store text.
            char character; // Stores a single character (inlcuding space, newline, etc.)
            int whileNumber; // Int stores a number without a decimal point (positive or negative)
            // byte, short and long are other integer types with varying size limits.
            double number; // Double stores a number with a decimal point.
            // float and ceimal are alternatives with quirks. Google them if you plan to use them.
            bool boolean; // bool stores a true or false value.

            string name; // Declare our variable.
            int age, birthYear;

            Console.WriteLine("Please enter your name below:"); // Tell the user what we're expecting.
            name = Console.ReadLine(); // Assign a value to the variable.

            Console.WriteLine("Please enter your age below:");
            age = int.Parse(Console.ReadLine());

            birthYear = 2020 - age;
            
            Console.WriteLine("Hello, " + name + "."); // Retrieve the value from the variable and send it to the console.
        }
    }
}
