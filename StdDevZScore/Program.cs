namespace StdDevZScore;
internal static class Program
{
    public static void Main(string[] args)
    {
            
        Console.WriteLine("Welcome to Mr Bob's Std Deviation and Z-Score Calculator!\n");
        List<double> numbers;
        
        while (true)
        {
            Console.Write("Input numbers: ");
            var numberList = Console.ReadLine();

            if (numberList != null && !numberList.Contains(',') && numberList.Length < 4) continue;
            numbers = numberList!.Split(',').Select(s => s.Trim()).Select(double.Parse).ToList();
            break;
        }
            
        var n = numbers.Count;
        var mean = numbers.Sum() / n;
        var sumOfXMeanSqrd = numbers.Sum(number => Math.Pow(number - mean, 2));
        var variancePop = sumOfXMeanSqrd / n;
        var varianceSam = sumOfXMeanSqrd / (n - 1);
        var stdDevPop = Math.Sqrt(variancePop);
        var stdDevSam = Math.Sqrt(varianceSam);
            
        Console.WriteLine($"\nThe Mean is {mean}.");
        Console.WriteLine($"The Standard Deviation (Population) is {Math.Round(stdDevPop, 2)}.");
        Console.WriteLine($"The Standard Deviation (Sample) is {Math.Round(stdDevSam, 2)}.\n");
            
        Console.WriteLine("Get Z-Score? Type Y to Continue... ");
        if (Console.ReadLine()?.ToLower() == "y") ZScore(mean, stdDevPop, stdDevSam);
    }

    private static void ZScore(double mean, double stdDevPop, double stdDevSam)
    {
        double x;
        while (true)
        {
            Console.Write("\nObserved value: ");
            if (double.TryParse(Console.ReadLine(), out x)) break;
        }

        var zScorePop = (x - mean) / stdDevPop;
        var zScoreSam = (x - mean) / stdDevSam;
        Console.WriteLine($"\nThe Z-Score (Population) is {Math.Round(zScorePop, 2)}.");
        Console.WriteLine($"The Z-Score (Sample) is {Math.Round(zScoreSam, 2)}.");
    }
}