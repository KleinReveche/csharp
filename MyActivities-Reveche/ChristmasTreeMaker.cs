using System;

namespace MyActivities_Reveche
{
    public static class ChristmasTreeMaker
    {
        private static int _treeStackSize;
        private static int _treeSize;
        private static int _treeSizeIncrement;
        private static char _treeSymbol = '*';
        public static void MakeChristmasTree()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.Write("Welcome to the Christmas Tree Maker!\n\n");
            _treeStackSize = Inputs.GetInt("  Enter Christmas Tree Size:");
            _treeSize = Inputs.GetInt("  Enter Starting Size:");
            _treeSizeIncrement = Inputs.GetInt("  Enter Size Increment:");
            _treeSymbol = Inputs.GetChar("  Enter Christmas Tree Symbol:");

            Console.WriteLine();
            for (var i = _treeStackSize; i > 0 ; i--)
            {
                MakeTree(_treeSize, i);
                _treeSize += _treeSizeIncrement;
            }
            MakeTrunk();
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void MakeTree(int size, int iteration)
        {
            for (var i = 1; i <= size; i++)
            {
                var symbols = 2 * i - 1;
                var spaces = size - i + iteration * _treeSizeIncrement;

                if (iteration == _treeStackSize && i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(new string(' ', spaces) + "★");
                }
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(new string(' ', spaces));

                for (var j = 0; j < symbols; j++)
                    Console.Write(_treeSymbol);
                
                Console.WriteLine();
            }
        }

        private static void MakeTrunk()
        {
            for (var i = 1; i <= _treeStackSize; i++)
            {
                var spaces = _treeStackSize * _treeSizeIncrement;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(new string(' ', spaces) + "[|]");
            }
        }
    }
}