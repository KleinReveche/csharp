using System;
using System.Collections.Generic;
using System.Linq;

namespace MyActivities_Reveche
{
    /** This is an alternative implementation of the activities.  */
    public class Alt
    {
        public static void HighestLowestArrays()
        {
            // with use of Arrays
            var numbers = new int[5];

            Console.WriteLine("Input 5 Numbers:");
            Console.Write("> ");
            numbers[0] = int.Parse(Console.ReadLine());
            Console.Write("> ");
            numbers[1] = int.Parse(Console.ReadLine());
            Console.Write("> ");
            numbers[2] = int.Parse(Console.ReadLine());
            Console.Write("> ");
            numbers[3] = int.Parse(Console.ReadLine());
            Console.Write("> ");
            numbers[4] = int.Parse(Console.ReadLine());

            Console.WriteLine("The highest value is {0}.", numbers.Max());
            Console.WriteLine("The lowest value is {0}.", numbers.Min());
        }

        public static void HighestLowestLists()
        {
            // with use of Lists
            var numbers = new List<int>();

            Console.WriteLine("Input 5 Numbers:");
            Console.Write("> ");
            numbers.Add(int.Parse(Console.ReadLine()));
            Console.Write("> ");
            numbers.Add(int.Parse(Console.ReadLine()));
            Console.Write("> ");
            numbers.Add(int.Parse(Console.ReadLine()));
            Console.Write("> ");
            numbers.Add(int.Parse(Console.ReadLine()));
            Console.Write("> ");
            numbers.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("The highest value is {0}.", numbers.Max());
            Console.WriteLine("The lowest value is {0}.", numbers.Min());
        }

        public static void ForLoopWithCount()
        {
            int count = 0, sum = 0;
            Console.WriteLine("Welcome to Average Plus!\n");

            Console.Write("Enter how many would you like to average: ");
            count = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter {0} Numbers:", count);
            for (int i = 0; i < count; i++)
            {
                Console.Write("> ");
                sum = sum + int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nThe Average is {0}", (float) sum / count);
        }

        public static void ForLoopSortedNumbersSafe()
        {
            bool isValid = false;
            int count = 0;
            string order;

            while (!isValid)
            {
                Console.Write("Enter number of loop/s: ");
                if (int.TryParse(Console.ReadLine(), out count))
                    isValid = true;
            }

            Console.Write("In what order would you like to display? [asc/desc]: ");
            order = Console.ReadLine().ToLower();

            if (order == "asc")
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write((i < count) ? i + ", " : i.ToString());
                }
                Console.WriteLine();
            }
            else if (order == "desc")
            {
                for (int i = count; i > 0; i--)
                {
                    Console.Write((i > 1) ? i + ", " : i.ToString());
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid Sort Direction.");
            }
        }

        public static void ForLoopOddEven2()
        {
            int n = 0, number = 0, evenCount = 0, oddCount = 0, sumEven = 0, sumOdd = 0;
            bool isValid = false;

            Console.WriteLine("Welcome to my Odd-Even-inator!\n");
            while (!isValid)
            {
                Console.Write("Enter n times: ");
                if (int.TryParse(Console.ReadLine(), out n))
                    isValid = true;
            }

            Console.WriteLine($"\nEnter {n} numbers:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("> ");
                number = int.Parse(Console.ReadLine());
                isValid = false;

                if (number < 1)
                {
                    while (!isValid)
                    {
                        Console.Write("[Error: Enter a number more than 0] > ");
                        if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                            isValid = true;
                    }
                }

                if (number % 2 == 0)
                {
                    evenCount++;
                    sumEven += number;
                }
                else
                {
                    oddCount++;
                    sumOdd += number;
                }
            }

            Console.WriteLine($"\nThe # of even numbers is {evenCount}");
            Console.WriteLine($"The sum of even numbers is {sumEven}");
            Console.WriteLine($"The # of odd numbers is {oddCount}");
            Console.WriteLine($"The sum of odd numbers is {sumOdd}");

        }
    }
}