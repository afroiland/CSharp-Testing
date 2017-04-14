using System;
using System.Collections;

namespace c__testing
{
    class Program
    {
        static void Main(string[] args)
        {

            
        }


        // If statement syntax, also {0}, {1} thing:
        //
        // {
        //     Console.WriteLine("enter the number one");
        //     string userValue = Console.ReadLine();
        //     string message = (userValue == "1") ? "success" : "failure";
        //     Console.WriteLine("You entered {0}, achieving {1}.", userValue, message);
        //     Console.ReadLine();
        // }


        // Easier way to create array, also Array.Sort() usage:
        //
        // {
        //     int[] numbers = {4, 3, 8, 0, 5};
        //     Array.Sort(numbers);
        //     foreach(int i in numbers)
        //         Console.WriteLine(i);
        // }


        // This is a more elaborate way to create an array:
        //
        // {
        //     string[] names = new string[2];
        //     names[0] = "Billy";
        //     names[1] = "Jimmy";
        //     for (int i = 0; i < names.Length; i++) {
        //         Console.WriteLine("Item number " + i + ": " + names[i]);
        //     }
        // }


        // Compare the results of the following if "ref" is removed in both places:
        //
        // {
        //     int number = 20;
        //     AddFive(ref number);
        //     Console.WriteLine(number);
        //     Console.ReadKey();
        // }
        // static void AddFive(ref int number)
        // {
        //   number = number + 5;
        // }
    }
}
