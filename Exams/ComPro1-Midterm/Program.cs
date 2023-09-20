using System;

namespace ComPro1_Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProblemOne();
            //ProblemTwo();
            ProblemThree();
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
            Console.WriteLine("Celsius  Farenheit");
            for (var celsius = 0; celsius <= 100; celsius++)
            {
                double farenheight = (celsius * 9 / 5.0) + 32;
                Console.WriteLine($"{celsius}        {farenheight}");
            }

            // One line impl.
            //for (var celsius = 0; celsius <= 100; celsius++) Console.WriteLine($"{celsius}        {(celsius * 9 / 5.0) + 32}");
        }

        static void ProblemThree()
        {
            int highest = 0, lowest = int.MaxValue, highestOccurences = 0, lowestOccurences = 0;
            string numbers = "";

            Console.WriteLine("Enter numbers: ");

            while (true)
            {

                Console.Write($"> ");
                var number = int.Parse(Console.ReadLine());

                if (number < 0) continue;

                numbers += $"{number} ";

                if (number == 0) break;

                if (number == highest)
                    highestOccurences++;

                if (number == lowest)
                    lowestOccurences++;

                if (number > highest)
                {
                    highest = number;
                    highestOccurences = 1;
                }

                if (number < lowest)
                {
                    lowest = number;
                    lowestOccurences = 1;
                }
            }
            Console.WriteLine($"\nNumbers are {numbers}");
            Console.WriteLine($"\nThe highest number is {highest}");
            Console.WriteLine($"The occurence of the highest number is {highestOccurences}");
            Console.WriteLine($"The lowest number is {lowest}");
            Console.WriteLine($"The occurence of the lowest number is {lowestOccurences}");
        }
    }
}
