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
            int max = 0, min = 0;

            Console.WriteLine("Input 5 Numbers:");
            Console.Write("> ");
            a = int.Parse(Console.ReadLine());
            Console.Write("> ");
            b = int.Parse(Console.ReadLine());
            Console.Write("> ");
            c = int.Parse(Console.ReadLine());
            Console.Write("> ");
            d = int.Parse(Console.ReadLine());
            Console.Write("> ");
            e = int.Parse(Console.ReadLine());

            if (a >= b && a >= c && a >= d && a >= e) max = a;
            if (b >= c && b >= d && b >= e && b >= a) max = b;
            if (c >= d && c >= e && c >= a && c >= b) max = c;
            if (d >= e && d >= a && d >= b && d >= c) max = d;
            if (e >= a && e >= b && e >= c && d >= b) max = e;

            if (a <= b && a <= c && a <= d && a <= e) min = a;
            if (b <= c && b <= d && b <= e && b <= a) min = b;
            if (c <= d && c <= e && c <= a && c <= b) min = c;
            if (d <= e && d <= a && d <= b && d <= c) min = d;
            if (e <= a && e <= b && e <= c && d <= b) min = e;

            Console.WriteLine("The highest value is {0}.", max);
            Console.WriteLine("The lowest value is {0}.", min);
        }

        static void MinMax2() 
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

        static void MinMax3()
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
