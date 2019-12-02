using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode;

namespace AdventOfCode19
{
    class DayTwo : Day
    {
        private string entry;

        public DayTwo()
        {
            entry = GetSingleEntry();
        }

        public override string GetSolutionPartOne()
        {
            var computer = new Computer(entry,12, 2);
            return computer.Run().ToString();
        }

        public override string GetSolutionPartTwo()
        {
            for (var noun = 0; noun < 100; noun++)
            {
                for (var verb = 0; verb < 100; verb++)
                {
                    var computer = new Computer(entry, noun, verb);
                    var result = computer.Run();
                    if (result == 19690720)
                    {
                        return (noun * 100 + verb).ToString();
                    }
                }
            }
            throw new Exception("result not found!");
        }
    }
}
