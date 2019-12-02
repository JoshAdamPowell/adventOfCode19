using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public abstract class Day
    {
        private string GetPath()
        {
            var name = GetType();
            return @"C:\Work\adventOfCode\2019\AdventOfCode19\AdventOfCode19\data\" + GetType().Name + ".txt";
        }

        protected IEnumerable<string> GetEntries()
        {
            var fileReader = new FileReader(GetPath());
            return fileReader.GetList();
        }

        protected string GetSingleEntry()
        {
            return GetEntries().First();
        }

        public virtual string GetSolutionPartOne()
        {
            throw new NotImplementedException();
        }

        public virtual string GetSolutionPartTwo()
        {
            throw new NotImplementedException();
        }
    }
}
