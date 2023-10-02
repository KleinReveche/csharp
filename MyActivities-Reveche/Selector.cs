using System;
using System.Collections.Generic;
using System.Reflection;

namespace MyActivities_Reveche
{
    public static class Selector
    {
        private static readonly List<Action> AvailableMethods = new List<Action>();
        private static readonly List<Action> AvailableAltMethods = new List<Action>();
        private static readonly List<Action> AvailablePlaygroundMethods = new List<Action>();

        internal static void Start(int selectedMethod = -1)
        {
            Console.Title = "MyActivities_Reveche";
            if (selectedMethod == -1) DisplayMenu(AvailableMethods);
            else AvailableMethods[selectedMethod].Invoke();
        }

        private static void AltMethods()
        {
            DisplayMenu(AvailableAltMethods, isAlt:true);
        }
        
        private static void PlaygroundMethods()
        {
            DisplayMenu(AvailablePlaygroundMethods, isPlayground:true);
        }

        private static void DisplayMenu(IReadOnlyList<Action> methodList, bool isAlt = false, bool isPlayground = false)
        {
            int index;
            var alt = (isAlt) ? "Alt " : "";
            var playground = (isPlayground) ? "Playground " : "";

            Console.WriteLine($"Welcome to Klein's CSharp {alt}{playground}Activities!\n");
            Console.WriteLine($"{alt}{playground}Methods: ");

            for (var i = 0; i < methodList.Count; i++)
            {
                var methodName = methodList[i].GetMethodInfo().ToString().Replace("Void ", "");
                Console.WriteLine($"  [{i}] {methodName}");
            }

            Console.WriteLine();

            while (true)
            {
                Console.Write("Select the method to run: ");
                if (int.TryParse(Console.ReadLine(), out index)) break;
            }

            Console.Clear();
            methodList[index].Invoke();
        }

        public static void RegisterMethods()
        {
            var methods = Selector.AvailableMethods;
            var altMethods = Selector.AvailableAltMethods;
            var playgroundMethods = Selector.AvailablePlaygroundMethods;

            // Add methods here to be invoked.
            methods.Add(Program.Arithmetic);
            methods.Add(Program.Grade);
            methods.Add(Program.HighestLowest);
            methods.Add(Program.ForLoop);
            methods.Add(Program.ForLoopSortedNumbers);
            methods.Add(Program.ForLoopOddEven);
            methods.Add(Program.WhileLoopSortedNumbers);
            methods.Add(Program.DoWhileLoopSortedNumbers);
            methods.Add(Program.QuizTwoLoops);
            methods.Add(Program.BmiCalculator);
            methods.Add(Program.NestedLoop);
            methods.Add(Program.NestedLoopWithInput);
            methods.Add(Program.NestedLoopWithInputAndWhile);
            methods.Add(Program.NestedLoopWithInputAndWhileAndColour);
            methods.Add(Program.NestedLoopWithInputAndWhileAndColourEdgeOnly);
            methods.Add(Program.ConsoleSetPosition);
            methods.Add(ChristmasTreeMaker.MakeChristmasTree);
            methods.Add(Program.WhileNestedLoops);
            methods.Add(Program.MultiplicationTableCursorPos);
            methods.Add(Program.ForLoopTable);

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

        }
    }
}