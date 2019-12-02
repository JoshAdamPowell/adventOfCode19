using AdventOfCode19;
using System;

namespace AdventOfCode
{
    public static class DayFactory
    {
        public static Day GetDay(int day)
        {
            switch (day)
            {
                case 1:
                    return new DayOne();
                case 2:
                    return new DayTwo();
                default:
                    throw new NotImplementedException("Day not available in factory.");
            }
        }
    }
}
