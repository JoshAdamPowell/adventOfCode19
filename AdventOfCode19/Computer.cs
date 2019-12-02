using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode19
{
    class Computer
    {
        private readonly List<int> _memory;
        private Dictionary<int, Func<int, int, int>> actions;

        public Computer(string memory, int noun, int verb)
        {
            _memory = memory.Split(',').Select(int.Parse).ToList();
            _memory[1] = noun;
            _memory[2] = verb;
            actions = new Dictionary<int, Func<int, int, int>>
            {
                { 1, (x, y) => x + y },
                { 2, (x, y) => x * y }
            };

        }

        public void RunInstruction(int opCode, int address1, int address2, int outputAddress)
        {
            var input1 = _memory[address1];
            var input2 = _memory[address2];
            var op = actions[opCode];
            var result = op(input1, input2);
            _memory[outputAddress] = result;
        }

        public int Run()
        {
            var pointer = 0;
            while (true)
            {
                var opCode = _memory[pointer];
                if (opCode == 99)
                {
                    return _memory[0];
                }
                RunInstruction(opCode, _memory[pointer + 1], _memory[pointer + 2], _memory[pointer + 3]);
                pointer += 4;
            }
        }
    }
}
