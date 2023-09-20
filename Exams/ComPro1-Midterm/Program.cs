using System;

namespace ComPro1_Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProblemOne();
            ProblemTwo();
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
    }
}