using System;

namespace MIDTERM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProblemOne();
            //ProblemTwo();
            //ProblemThree();

            //ProblemOneAdjusted(); // Made to correct the code for the specification.
            //ProblemTwoAdjusted();

            RemedialProblemOne();
            RemedialProblemTwo();
            RemedialProblemThree();
            RemedialProblemFour(); // Nested for loops impl.
            RemedialProblemFourAlt(); // 2 for loops
            RemedialProblemFourAlt2(); // 1 for loop
        }

        static void ProblemOne()
        {
            Console.Write("Enter your score: ");
            var score = int.Parse(Console.ReadLine());

            if (score < 0) Console.WriteLine("No numbers are entered except 0.");
            else if (score >= 60) Console.WriteLine("You pass the exam.");
            else Console.WriteLine("You didn't pass the exam");
        }

        static void ProblemTwo()
        {
            Console.WriteLine("Celsius  Fahrenheit");
            for (var celsius = 0; celsius <= 100; celsius++)
            {
                double fahrenheit = (celsius * 9 / 5.0) + 32;
                Console.WriteLine($"{celsius}        {fahrenheit}");
            }
        }

        static void ProblemThree()
        {
            int highest = 0, lowest = int.MaxValue, highestOccurrences = 0, lowestOccurrences = 0;
            var numbers = "";

            Console.WriteLine("Enter numbers: ");
            
            while (true)
            {

                Console.Write($"> ");
                var number = int.Parse(Console.ReadLine() ?? "-1");

                if (number < 0) continue;

                numbers += $"{number} ";

                if (number == 0) break;

                if (number == highest)
                    highestOccurrences++;

                if (number == lowest)
                    lowestOccurrences++;

                if (number > highest)
                {
                    highest = number;
                    highestOccurrences = 1;
                }

                if (number >= lowest) continue;
                lowest = number;
                lowestOccurrences = 1;
            }
            Console.WriteLine($"\nNumbers are {numbers}");
            Console.WriteLine($"\nThe highest number is {highest}");
            Console.WriteLine($"The occurrence of the highest number is {highestOccurrences}");
            Console.WriteLine($"The lowest number is {lowest}");
            Console.WriteLine($"The occurrence of the lowest number is {lowestOccurrences}");
        }

        static void ProblemOneAdjusted()
        {
            while (true)
            {
                Console.Write("Enter your score: ");
                var score = int.Parse(Console.ReadLine() ?? "-1");

                if (score < 0) break;

                Console.WriteLine(score >= 60 ? "You pass the exam." : "You didn't pass the exam.");
            }
        }

        static void ProblemTwoAdjusted()
        {
            Console.WriteLine("Celsius  Fahrenheit");
            for (var celsius = 0; celsius <= 100; celsius += 2)
                Console.WriteLine($"{celsius}        {(celsius * 9 / 5.0) + 32}");
        }

        static void RemedialProblemOne()
        {
            for (var i = 1; i <= 10; i++) Console.Write($"{i} ");
            Console.WriteLine("\n");
        }

        static void RemedialProblemTwo()
        {
            for (var i = 10; i >= 1; i--) Console.Write($"{i} ");
            Console.WriteLine("\n");
        }

        static void RemedialProblemThree()
        {
            Console.Write("Input number of terms: ");
            var input = int.Parse(Console.ReadLine() ?? "0");

            for (var i = 1; i <= input; i++)
                Console.WriteLine($"Number is: {i} and cube of the {i} is: {Math.Pow(i, 3)}"); // or i * i * i
        }

        static void RemedialProblemFour()
        {
            Console.Write("\nInput the number of terms: ");
            var input = int.Parse(Console.ReadLine() ?? "0");
            var sum = 0;

            for (var i = 1; i <= input; i++)
            {
                var nines = "";
                for (var j = 1; j <= i; j++) nines += "9";
                var currentSum = int.Parse(nines);
                sum += currentSum;

                Console.Write($"{nines} ");
            }

            Console.WriteLine($"\nThe sum of the series: {sum}\n");
        }

        static void RemedialProblemFourAlt()
        {
            Console.Write("\nInput the number of terms: ");
            var input = int.Parse(Console.ReadLine() ?? "0");
            var sum = 0;
            var nines = "";

            for (var i = 1; i <= input; i++) nines += "9";

            for (var i = input; i > 0; i--)
            {
                var currentSum = int.Parse(nines) / (int) Math.Pow(10, i - 1);
                sum += currentSum;

                Console.Write($"{currentSum} ");
            }

            Console.WriteLine($"\nThe sum of the series: {sum}\n");
        }

        static void RemedialProblemFourAlt2()
        {
            Console.Write("\nInput the number of terms: ");
            var input = int.Parse(Console.ReadLine() ?? "0");
            int number = 0, sum = 0;

            for (var i = 1; i <= input; i++)
            {
                number += 9 * (int) Math.Pow(10, i - 1);
                sum += number;

                Console.Write($"{number} ");
            }

            Console.WriteLine($"\nThe sum of the series: {sum}\n");
        }
    }
}
