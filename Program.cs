using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {   // Ranges of Numeric Data-Types

            // int
            Console.WriteLine("Smallest number in int is: " + int.MinValue);
            Console.WriteLine("Largest number in int is: " + int.MaxValue);

            // long
            Console.WriteLine("Smallest number in long is: " + long.MinValue);
            Console.WriteLine("Largest number in long is: " + long.MaxValue);

            // float
            // -3.40 x 100000000000000000000000000000000000000
            Console.WriteLine("smallest number in float is: " + float.MinValue);
            Console.WriteLine("largest number in float is: " + float.MaxValue);

            // double
            Console.WriteLine("smallest number in double is: " + double.MinValue);
            Console.WriteLine("largest number in double is: " + double.MaxValue);

            // decimal
            Console.WriteLine("smallest number in decimal is: " + decimal.MinValue);
            Console.WriteLine("largest number in decimal is: " + decimal.MaxValue);

            // char - used to store a single character 'a' NPC Non-Printable Character
            Console.WriteLine("Range for char is from " + char.MinValue + " to " + char.MaxValue);

            // bool - true or false
            Console.WriteLine(bool.FalseString + " and " + bool.TrueString);

            // string - a string of characters


            // DateTime
            Console.WriteLine(DateTime.MaxValue);
        }
    }
}
