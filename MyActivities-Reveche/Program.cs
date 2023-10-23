using System;

namespace MyActivities_Reveche
{
    public static partial class Program
    {
        public static void Main(string[] args) 
        {
            Console.Clear();
            Selector.RegisterMethods();
            
            // Modify this to directly run the method you want.
            var selectedMethod = -1; // Change this to always be -1 when done.

            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (selectedMethod != -1 || (args.Length > 0 && int.TryParse(args[0], out selectedMethod)))
                Selector.Start(selectedMethod);
            else
                Selector.Start();

            Console.ReadKey();
        }

        public static void NestedLoop()
        {
            for (var row = 1; row <= 5; row++)
            {
                for (var col = 1; col <= 5; col++)
                    Console.Write($"{col} ");
                Console.WriteLine();
            }
        }

        public static void NestedLoopWithInput()
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

        public static void NestedLoopWithInputAndWhile()
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
        public static void NestedLoopWithInputAndWhileAndColour()
        {
            int size;
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
        
        public static void NestedLoopWithInputAndWhileAndColourEdgeOnly()
        {
            int size;
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

        public static void ConsoleSetPosition()
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
        
        
        public static void WhileNestedLoops()
        {
            const int size = 5;
            var row = 1;

            while (row <= size)
            {
                var col = 1;
                while (col <= size)
                {
                    Console.Write($"{Math.Pow(col, col)} ");
                    col++;
                }
                Console.WriteLine();
                row++;
            }
        }
        
        public static void MultiplicationTableCursorPos()
        {
            const int size = 10;
            var row = 1; 
            while (row <= size)
            {
                var col = 1;
                while (col <= size)
                {
                    var currentProduct = row * col;
                    
                    Console.SetCursorPosition(col * 3, row);
                    Console.Write($"{currentProduct}");
                    col++;
                }
                Console.WriteLine();
                row++;
            }
        }

        public static void ForLoopTable()
        {
            const int size = 5;
            int oddSum = 0, evenSum = 0, row1 = 0, row2 = 0, row3 = 0, row4 = 0, row5 = 0;

            for (var row = 1; row <= size; row++)
            {
                int odd = 0, even = 0;
                
                for (var col = 1; col <= size; col++)
                {
                    Console.Write($"{col}  ");
                    
                    if (col % 2 == 0)
                        even += col;
                    else
                        odd += col;

                    switch (col)
                    {
                        case 1:
                            row1 += col;
                            break;
                        case 2:
                            row2 += col;
                            break;
                        case 3:
                            row3 += col;
                            break;
                        case 4:
                            row4 += col;
                            break;
                        case 5:
                            row5 += col;
                            break;
                    }
                }
                
                Console.WriteLine($"{odd}  {even}");
                evenSum += even;
                oddSum += odd;
            }
            Console.WriteLine($"{row1} {row2} {row3} {row4} {row5} {oddSum} {evenSum}");
        }

        public static void PrimeNumbers()
        {
            var primeNumbers = "";
            for (var i = 1; i <= 100; i++)
            {
                var isPrime = IsPrime(i);
                if (isPrime) primeNumbers += $"{i}, ";
                Console.WriteLine($"{i} is {(isPrime ? "" : "not ")}a prime.");   
            }

            Console.WriteLine($"\nThe Prime Numbers are: {primeNumbers.TrimEnd(',', ' ')}.");
            
            return;
            
            bool IsPrime(int number)
            {
                if (number <= 1 || (number % 2 == 0 && number != 2) ) return false;
                if (number is 2 || number is 3) return true;

                for (var i = 3; i * i <= number; i++)
                {
                    if (number % i == 0) return false;
                }
                
                return true;
            }
        }
    }
}
