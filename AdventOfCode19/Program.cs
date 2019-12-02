using System;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What date is it today?");
            var input = Console.ReadLine();
            if (input == null)
            {
                throw new Exception("day be null!");
            }
            var today = DayFactory.GetDay(int.Parse(input));
            Console.WriteLine("Solving puzzle for today!");
            var resultOne = today.GetSolutionPartOne();
            Console.WriteLine("solution for part one is: " + resultOne);
            Console.ReadLine();
            Console.WriteLine("getting solution to part 2...");
            var resultTwo = today.GetSolutionPartTwo();
            Console.WriteLine("solution for part two is: " + resultTwo);


            Console.WriteLine("Any key to continue...");
            Console.ReadLine();
        }
    }
}
