using System;
using System.Collections.Generic;
using System.Linq;

namespace MyActivities_Reveche
{
    /// <summary> This is an alternative implementation of the activities. </summary>
    public static class Alt
    {
        /// <summary> Gets an int input from user and checks if valid. </summary>
        private static void ReadAndCheckInt(string message, out int input)
        {
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out input)) break;
            }
        }

        public static void HighestLowestArrays()
        {
            // with use of Arrays
            var numbers = new int[5];

            // with for loops
            Console.WriteLine("Input 5 Numbers:");
            for (var i = 0; i < 5; i++)
                ReadAndCheckInt("> ", out numbers[i]);

            Console.WriteLine("The highest value is {0}.", numbers.Max());
            Console.WriteLine("The lowest value is {0}.", numbers.Min());
        }

        public static void HighestLowestLists()
        {
            // with use of Lists
            var numbers = new List<int>();

            // with for loops
            Console.WriteLine("Input 5 Numbers:");
            for (var i = 0; i < 5; i++)
            {
                ReadAndCheckInt("> ", out var number);
                numbers.Add(number);
            }

            Console.WriteLine("The highest value is {0}.", numbers.Max());
            Console.WriteLine("The lowest value is {0}.", numbers.Min());
        }

        public static void ForLoopWithCount()
        {
            var sum = 0;
            Console.WriteLine("Welcome to Average Plus!\n");

            ReadAndCheckInt("Enter how many would you like to average: ", out var count);

            Console.WriteLine("\nEnter {0} Numbers:", count);
            for (var i = 0; i < count; i++)
            {
                ReadAndCheckInt("> ", out var num);
                sum += num;
            }
            Console.WriteLine("\nThe Average is {0}", (float)sum / count);
        }

        public static void ForLoopSortedNumbersSafe()
        {
            ReadAndCheckInt("Enter number of loop/s: ", out var count);

            Console.Write("In what order would you like to display? [asc/desc]: ");
            var order = Console.ReadLine()?.ToLower();

            switch (order)
            {
                case "asc":
                {
                    for (var i = 1; i <= count; i++)
                    {
                        Console.Write((i < count) ? i + ", " : i.ToString());
                    }
                    Console.WriteLine();
                    break;
                }
                case "desc":
                {
                    for (var i = count; i > 0; i--)
                    {
                        Console.Write((i > 1) ? i + ", " : i.ToString());
                    }
                    Console.WriteLine();
                    break;
                }
                default:
                    Console.WriteLine("Invalid Sort Direction.");
                    break;
            }
        }

        public static void ForLoopOddEven2()
        {
            int evenCount = 0, oddCount = 0, sumEven = 0, sumOdd = 0;
            string oddNumbers = "", evenNumbers = "";

            Console.WriteLine("Welcome to my Odd-Even-inator!\n");

            ReadAndCheckInt("Enter n times: ", out var n);

            Console.WriteLine($"\nEnter {n} numbers:");
            for (var i = 0; i < n; i++)
            {
                ReadAndCheckInt("> ", out var number);

                if (number < 1)
                {
                    ReadAndCheckInt("[Error: Enter a number more than 0] > ", out number);
                }

                if (number % 2 == 0)
                {
                    evenCount++;
                    sumEven += number;
                    evenNumbers += $"{number + (((evenCount + oddCount) < n - 1) ? ", " : "")}";
                }
                else
                {
                    oddCount++;
                    sumOdd += number;
                    oddNumbers += $"{number + (((evenCount + oddCount) < n - 1) ? ", " : "")}";
                }
            }

            Console.WriteLine($"\nThe # of even numbers is {evenCount}, which is [{evenNumbers}]");
            Console.WriteLine($"The sum of even numbers is {sumEven}");
            Console.WriteLine($"The # of odd numbers is {oddCount}, which is [{oddNumbers}]");
            Console.WriteLine($"The sum of odd numbers is {sumOdd}\n");

        }
    }
}