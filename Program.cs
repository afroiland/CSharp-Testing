using System;
using System.Collections;

namespace c__testing
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;
            AddFive(ref number);
            Console.WriteLine(number);
            Console.ReadKey();
        }
        static void AddFive(ref int number)
        {
          number = number + 5;
        }
    }
}
