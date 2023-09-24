using System;

namespace LeapYearPractice
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Title = "Leap Year Practice";
                Console.Write("Enter a year: ");
                var year = int.Parse(Console.ReadLine() ?? "-1");

                if (year < 0) break;
                
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                    Console.WriteLine($"{year} is a leap year.\n");
                else Console.WriteLine($"{year} is not a leap year.\n");
            }
        }
    }
}