using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class Problem2A : IProblem
    {
        public void Run()
        {
            var total = File.ReadLines("../../Input2.txt")
                .Sum(line => 3 * ((line[2] - line[0] + 2) % 3) + line[2] - 87);

            Console.WriteLine(total);
        }
    }
}