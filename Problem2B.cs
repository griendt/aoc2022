using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class Problem2B : IProblem
    {
        public void Run()
        {
            var total = File.ReadLines("../../Input2.txt")
                .Sum(line => 1 + (line[0] + line[2] - 151) % 3 + 3 * (line[2] - 88));

            Console.WriteLine(total);
        }
    }
}