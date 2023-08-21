using System;

namespace SuperSimpleCalc
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Simple Calc!");
            Console.WriteLine("A simple calculation for every operation!\n");

            long x = GetInput("x");
            long y = GetInput("y");

            var add = x + y;
            var subtract = x - y;
            var multiply = x * y;
            double divide = (double)x / y;

            Console.WriteLine("\nAnswers:");
            Console.WriteLine($"{x} + {y} = {add}");
            Console.WriteLine($"{x} - {y} = {subtract}");
            Console.WriteLine($"{x} * {y} = {multiply}");

            if (double.IsNaN(divide))
                Console.WriteLine($"{x} / {y} = Result is undefined\n");
            else
                Console.WriteLine($"{x} / {y} = {divide}\n");
        }

        static long GetInput(string name)
        {
            long input = 0;
            bool isValid = false;

            while (!isValid)
            {
                try
                {
                    Console.Write($"{name}: ");
                    input = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch { isValid = false; }
            }

            return input;
        }
    }
}
