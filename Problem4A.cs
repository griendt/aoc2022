using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class Problem4A : IProblem
    {
        public void Run()
        {
            var count = 0;

            foreach (var line in File.ReadLines("../../Input4.txt"))
            {
                var split = line.Split(',');
                var firstInterval = split[0].Split('-').Select(int.Parse).ToArray();
                var secondInterval = split[1].Split('-').Select(int.Parse).ToArray();

                if (
                    (firstInterval[0] >= secondInterval[0] && firstInterval[1] <= secondInterval[1]) ||
                    (secondInterval[0] >= firstInterval[0] && secondInterval[1] <= firstInterval[1])
                )
                {
                    count += 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}