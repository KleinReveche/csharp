using System;
using System.Collections.Generic;
using System.Linq;

namespace MyActivities_Reveche
{
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
    }
}