using System;
using System.Security.Cryptography;

namespace LoopsAndDebugger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //FizzBuzzExample();
            Solution();
        }

        static void ForLoop()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void WhileLoop()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i);
            }

            // Another Sample Implementation
            while (true)
            {
                Console.Write("Give a number: ");
                var input = int.Parse(Console.ReadLine());

                if (input == 5)
                    break;
            }
        }

        static void DoWhileLoop()
        {
            int i = 1;
            do
            {
                Console.WriteLine(i);
            }
            while (i <= 5) ;

            // Another Sample Implementation
            do
            {
                Console.Write("Give a number: ");
                var input = int.Parse(Console.ReadLine());

                if (input == 5)
                    break;
            }
            while (true);

        }

        static void FizzBuzzExample()
        {
            for (int number = 1; number <= 100; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                    Console.WriteLine("FIZZBUZZ");

                else if (number % 3 == 0)
                    Console.WriteLine("FIZZ");

                else if (number % 5 == 0)
                    Console.WriteLine("BUZZ");

                else Console.WriteLine(number);
            }
        }

        static void Solution()
        {
            var oddEvenResult = "";
            var num = 5;

            for (var i = 1; i <= num * 2; i++)
            {
                if (i % 2 == 0) 
                    oddEvenResult += $"{i - 1 + i}, ";
            }
            Console.WriteLine(oddEvenResult.Substring(0, oddEvenResult.Length - 2));
        }
    }
}
