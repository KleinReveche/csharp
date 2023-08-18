using System;

namespace SuperSimpleCalc
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Simple Calc!");
            Console.WriteLine("A simple calculation for every operation!\n");

            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());

            var add = x + y;
            var subtract = x - y;
            var multiply = x * y;
            float divide = (float) x / y;

            Console.WriteLine("\nAnswers:");
            Console.WriteLine($"{x} + {y} = {add}");
            Console.WriteLine($"{x} - {y} = {subtract}");
            Console.WriteLine($"{x} * {y} = {multiply}");

            if (float.IsNaN(divide))
                Console.WriteLine($"{x} / {y} = Result is undefined\n");
            else
                Console.WriteLine($"{x} / {y} = {divide}\n");
        }
    }
}
