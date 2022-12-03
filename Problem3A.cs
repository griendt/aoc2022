using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class Problem3A : IProblem
    {
        public void Run()
        {
            var total = 0;

            foreach (var line in File.ReadLines("../../Input3.txt"))
            {
                var itemsSeen = new HashSet<char>(line.Substring(0, line.Length / 2));
                foreach (var item in line.Substring(line.Length / 2))
                {
                    if (!itemsSeen.Contains(item)) continue;
                    
                    total += item - (char.IsLower(item) ? 96 : 38);
                    break;
                }
            }

            Console.WriteLine(total);
        }
    }
}