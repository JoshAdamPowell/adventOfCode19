using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode;

namespace AdventOfCode19
{
    class DayOne : Day
    {
        private int CalcMass(int mass)
        {
            return ((mass / 3) - 2);
        }

        private int GetAmountOfFuel(int module)
        {
            var fuelTotal = 0;
            var fuelCost = CalcMass(module);
            fuelTotal += fuelCost;
            while (CalcMass(fuelCost) > 0)
            {
                fuelCost = CalcMass(fuelCost);
                fuelTotal += fuelCost;
            }

            return fuelTotal;
        }

        public override string GetSolutionPartOne()
        {
            var entries = GetEntries();
            var results = entries.Select((x) => (int.Parse(x) / 3) - 2).ToList();
            return results.Sum().ToString();
        }

        public override string GetSolutionPartTwo()
        {
            var entries = GetEntries().Select(int.Parse);
            var results = entries.Select(GetAmountOfFuel);
            return results.Sum().ToString();
        }

    }
}
