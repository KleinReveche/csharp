using System;

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
                    var padding = maxProduct.ToString().Length - currentProduct.ToString().Length + 1;
                    Console.Write((col == 1 ? $"{row}" : $"{currentProduct}") + new string(' ', padding / 2));
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
            const string bingo = "BINGO";
            const int size = 6;
            var random = new Random();

            for (var row = 1; row <= size; row++)
            {
                for (var col = 1; col <= size - 1; col++)
                {
                    switch (row)
                    {
                        case 1:
                            Console.Write($"  {bingo[col - 1]}  ");
                            continue;
                        case 3 when col == 3:
                            Console.Write(" F ");
                            break;
                    }

                    var number = 0;
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
                    
                    Console.Write($" {number} ");
                }
                Console.WriteLine();
            }
        }
    }
}