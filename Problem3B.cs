using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class Problem3B : IProblem
    {
        public void Run()
        {
            var total = 0;
            var linesReadPerGroup = 0;
            var commonItems = new HashSet<char>();

            foreach (var line in File.ReadLines("../../Input3.txt"))
            {
                linesReadPerGroup += 1;

                if (linesReadPerGroup == 1)
                    commonItems = new HashSet<char>(line);
                else
                    commonItems.IntersectWith(line);

                if (linesReadPerGroup == 3)
                {
                    var item = commonItems.First();
                    total += item - (char.IsLower(item) ? 96 : 38);
                    linesReadPerGroup = 0;
                }
            }

            Console.WriteLine(total);
        }
    }
}