using System;

namespace MyActivities_Reveche
{
    public static partial class Program
    {
        public static void Main(string[] args)
        {
            // Modify this to directly run the method you want.
            var selectedMethod = -1; // Change this to always be -1 when done.

            var methods = Selector.AvailableMethods;
            var altMethods = Selector.AvailableAltMethods;
            var playgroundMethods = Selector.AvailablePlaygroundMethods;

            // Add methods here to be invoked.
            methods.Add(Arithmetic);
            methods.Add(Grade);
            methods.Add(HighestLowest);
            methods.Add(ForLoop);
            methods.Add(ForLoopSortedNumbers);
            methods.Add(ForLoopOddEven);
            methods.Add(WhileLoopSortedNumbers);
            methods.Add(DoWhileLoopSortedNumbers);
            methods.Add(QuizTwoLoops);
            methods.Add(BmiCalculator);
            methods.Add(NestedLoop);
            methods.Add(NestedLoopWithInput);
            methods.Add(NestedLoopWithInputAndWhile);
            methods.Add(NestedLoopWithInputAndWhileAndColour);
            methods.Add(NestedLoopWithInputAndWhileAndColourEdgeOnly);
            methods.Add(ConsoleSetPosition);

            // These are extra alternative implementations of the activities
            methods.Add(Selector.AltMethods);
            altMethods.Add(Alt.HighestLowestArrays);
            altMethods.Add(Alt.HighestLowestLists);
            altMethods.Add(Alt.ForLoopWithCount);
            altMethods.Add(Alt.ForLoopSortedNumbersSafe);
            altMethods.Add(Alt.ForLoopOddEven2);
            
            // These are the things that I tinker with
            methods.Add(Selector.PlaygroundMethods);
            playgroundMethods.Add(Playground.MultiplicationTable);
            playgroundMethods.Add(Playground.Pyramid);
            playgroundMethods.Add(Playground.Bingo);
            

            if (selectedMethod != -1 || (args.Length > 0 && int.TryParse(args[0], out selectedMethod)))
                Selector.Start(selectedMethod);
            else
                Selector.Start();

            // This prevents the app from immediately closing when run from the terminal.
            Console.Write("Press any key to exit . . .");
            Console.ReadKey();
        }

        private static void NestedLoop()
        {
            for (var row = 1; row <= 5; row++)
            {
                for (var col = 1; col <= 5; col++)
                    Console.Write($"{col} ");
                Console.WriteLine();
            }
        }

        private static void NestedLoopWithInput()
        {
            Console.Write("Enter number table size: ");
            var size = int.Parse(Console.ReadLine() ?? "0");
            
            for (var row = 1; row <= size; row++)
            {
                for (var col = 1; col <= size; col++)
                {
                    Console.Write($"{col} ");
                }

                Console.WriteLine();
            }
        }

        private static void NestedLoopWithInputAndWhile()
        {
            while (true)
            {
                
                Console.Write("Enter number table size: ");
                var size = int.Parse(Console.ReadLine() ?? "0");

                if (size < 5 || size > 39)
                {
                    Console.Clear();
                    Console.WriteLine("[Error] Input a number between 5-39");
                    continue;
                }
            
                for (var row = 1; row <= size; row++)
                {
                    for (var col = 1; col <= size; col++)
                        Console.Write($"{col}  ");
                    Console.WriteLine();
                }
                break;
            }
        }
        private static void NestedLoopWithInputAndWhileAndColour()
        {
            var size = 0;
            while (true)
            {
                
                Console.Write("Enter number table size: ");
                size = int.Parse(Console.ReadLine() ?? "0");

                if (!(size < 5) && !(size > 39)) break;
                
                Console.Clear();
                Console.WriteLine("[Error] Input a number between 5-39");
            }
            
            for (var row = 1; row <= size; row++)
            {
                for (var col = 1; col <= size; col++)
                {
                    Console.BackgroundColor = col % 2 == 0 ? ConsoleColor.Cyan : ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write($" {col} ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        
        private static void NestedLoopWithInputAndWhileAndColourEdgeOnly()
        {
            var size = 0;
            while (true)
            {
                
                Console.Write("Enter number table size: ");
                size = int.Parse(Console.ReadLine() ?? "0");

                if (!(size < 5) && !(size > 39)) break;
                
                Console.Clear();
                Console.WriteLine("[Error] Input a number between 5-39");
            }
            
            for (var row = 1; row <= size; row++)
            {
                for (var col = 1; col <= size; col++)
                {
                    var isEdge = (col == 1 || col == size) || (row == 1 || row == size);
                    var whenDoubleDigit = $"{ ((col > 9) ? " " : "") }";
                    
                    Console.BackgroundColor = col % 2 == 0 ? ConsoleColor.Cyan : ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write($" {((isEdge) ? col.ToString() : $"{whenDoubleDigit} ")} ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        private static void ConsoleSetPosition()
        {
            for (var x = 1; x <= 5; x++)
            {
                for (var y = 1; y <= x; y++)
                {
                    Console.SetCursorPosition(y, x);
                    Console.Write($"{y}");
                }
            }
            Console.WriteLine();
        }
    }
}
