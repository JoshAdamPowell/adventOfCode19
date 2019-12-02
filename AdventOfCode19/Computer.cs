using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode19
{
    class Computer
    {
        private List<int> codes;
        private Dictionary<int, Func<int, int, int>> actions;

        public Computer(string codes, int input1, int input2)
        {
            this.codes = codes.Split(',').Select(int.Parse).ToList();
            this.codes[1] = input1;
            this.codes[2] = input2;
            actions = new Dictionary<int, Func<int, int, int>>
            {
                { 1, (x, y) => x + y },
                { 2, (x, y) => x * y }
            };

        }

        public void RunIteration(int opCode, int position1, int position2, int outputPosition)
        {
            var input1 = codes[position1];
            var input2 = codes[position2];
            var op = actions[opCode];
            var result = op(input1, input2);
            codes[outputPosition] = result;
        }

        public int Run()
        {
            var cursor = 0;
            while (true)
            {
                var opCode = codes[cursor];
                if (opCode == 99)
                {
                    return codes[0];
                }
                RunIteration(opCode, codes[cursor + 1], codes[cursor + 2], codes[cursor + 3]);
                cursor += 4;
            }
        }
    }
}
