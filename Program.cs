using System;
using System.Collections;

namespace c__testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test");

        }


        // While iteration
        //
        // {
        //     bool displayMenu = true;
        //     while (displayMenu == true)
        //     {
        //         displayMenu = MainMenu();
        //     }
        // }
        //
        // private static bool MainMenu()
        // {
        //     Console.Clear();
        //     Console.WriteLine("Choose an option:");
        //     Console.WriteLine("1) Option 1");
        //     Console.WriteLine("2) Option 2");
        //     Console.WriteLine("3) Exit");
        //     string result = Console.ReadLine();
        //     if (result == "1")
        //     {
        //         PrintNumbers();
        //         return true;
        //     }
        //     else if (result == "2")
        //     {
        //         GuessingGame();
        //         return true;
        //     }
        //     else if (result == "3")
        //     {
        //         return false;
        //     }
        //     else
        //     {
        //         return true;
        //     }
        // }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game");  
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;
            do
            {
                Console.WriteLine("Guess bewtween 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Incorrect");
            } while (incorrect);
            Console.WriteLine("Correct, after {0} guesses.", guesses);
            Console.ReadLine();
        }


        // Class and constructor (see new car class below):
        //
        // {
        //     Car car;
        //
        //     car = new Car("Red");
        //     Console.WriteLine(car.Describe());
        //
        //     car = new Car("Green");
        //     Console.WriteLine(car.Describe());
        //
        //     Console.ReadLine();
        // }


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

    class Car
    {
        private string color;

        public Car(string color)
        {
            this.color = color;
        }

        public string Describe()
        {
            return "This car is " + Color;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
