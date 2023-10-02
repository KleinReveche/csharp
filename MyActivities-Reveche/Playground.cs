using System;
using System.Collections.Generic;

namespace MyActivities_Reveche
{
    public static class Playground
    {
        public static void MultiplicationTable()
        {
            Console.Write("Enter number table size: ");
            var size = int.Parse(Console.ReadLine() ?? "0");
            var maxProduct = size * size;
            
            for (var row = 1; row <= size; row++)
            {
                for (var col = 1; col <= size; col++)
                {
                    Console.BackgroundColor = col % 2 == 0 ? ConsoleColor.Cyan : ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    var currentProduct = row * col;
                    var padding = maxProduct.ToString().Length - currentProduct.ToString().Length;
                    Console.Write(($"{currentProduct}") + new string(' ', padding));
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        
        public static void Pyramid()
        {
            const int size = 5;

            for (var i = 0; i < size; i++)
            {
                var hash = i + 1;
                var blank = size - i;

                for (var j = 0; j < blank - 1; j++)
                {
                    Console.Write(" ");
                }

                for (var j = 0; j < hash; j++)
                {
                    Console.Write("#");
                }
                
                for (var j = 0; j < hash - 1; j++)
                {
                    Console.Write("#");
                }
                
                Console.WriteLine();
            }
        }

        public static void Bingo()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const string bingo = "BINGO";
            const int size = 6;
            var numberList = new List<int>();
            
            for (var row = 1; row <= size; row++)
            {
                for (var col = 1; col <= size - 1; col++)
                {
                    Console.BackgroundColor = col % 2 == 0 ? ConsoleColor.Cyan : ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    
                    switch (row)
                    {
                        case 1:
                            Console.Write($" {bingo[col - 1]}  ");
                            continue;
                        case 4 when col == 3:
                            Console.Write(" ★★ ");
                            continue;
                    }

                    var number = BingoAlgorithm(col, numberList);

                    Console.Write($" {(number < 10 ? " " : "")}{number} ");
                }
                Console.WriteLine();
                Console.ResetColor();
            }
        }
        
        private static int BingoAlgorithm(int col, ICollection<int> numberList)
        {
            var random = new Random();
            var number = 0;

            while (true)
            {
                switch (col)
                {
                    case 1:
                        number = random.Next(1, 15);
                        break;
                    case 2:
                        number = random.Next(16, 30);
                        break;
                    case 3:
                        number = random.Next(31, 45);
                        break;
                    case 4:
                        number = random.Next(46, 60);
                        break;
                    case 5:
                        number = random.Next(61, 75);
                        break;
                }

                if (numberList.Contains(number)) continue;
                numberList.Add(number);
                break;
            }

            return number;
        }
    }
}