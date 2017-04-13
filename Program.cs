using System;
using System.Collections;

namespace c__testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[2];
            names[0] = "Billy";
            names[1] = "Jimmy";
            for (int i = 0; i < names.Length; i++) {
                Console.WriteLine("Item number " + i + ": " + names[i]);
            }


        }


        // Compare the results of the following if "ref" is removed in each place:
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
