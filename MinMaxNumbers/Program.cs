using System;
using System.Collections.Generic;
using System.Linq;

namespace MinMaxNumbers
{
    class Program
    {
        static void Main()
        {
            MinMax1();
        }

        static void MinMax1()
        {
            // Basic
            int a, b, c, d, e;
            int max = 0;

            Console.WriteLine("Input 5 Numbers:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            if (a > b && a > c && a > d && a > e) max = a;
            if (b > c && b > d && b > e && b > a) max = b;
            if (c > d && c > e && c > a && c > b) max = c;
            if (d > e && d > a && d > b && d > c) max = d;
            if (e > a && e > b && e > c && d > b) max = e;

            Console.WriteLine("The highest value is {0}.", max);
        }

        static void MinMax2() 
        {
            // with use of Arrays
            var numbers = new int[5];

            Console.WriteLine("Input 5 Numbers:");
            numbers[0] = int.Parse(Console.ReadLine()); 
            numbers[1] = int.Parse(Console.ReadLine()); 
            numbers[2] = int.Parse(Console.ReadLine()); 
            numbers[3] = int.Parse(Console.ReadLine()); 
            numbers[4] = int.Parse(Console.ReadLine()); 

            Console.WriteLine("The highest value is {0}.", numbers.Max());
        }

        static void MinMax3()
        {
            // with use of Lists
            var numbers = new List<int>();

            Console.WriteLine("Input 5 Numbers:");
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Add(int.Parse(Console.ReadLine()));
            numbers.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("The highest value is {0}.", numbers.Max());
        }
    }
}
