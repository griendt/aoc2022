using System;
using System.IO;

namespace AdventOfCode2022
{
    class Problem1A : IProblem
    {
        public void Run()
        {
            var maxCalories = 0;
            var currentCalories = 0;
            
            foreach (var line in File.ReadLines("../../Input1A.txt"))
            {
                if (line.Length != 0)
                {
                    currentCalories += int.Parse(line);
                    continue;
                }
                
                maxCalories = Math.Max(maxCalories, currentCalories);
                currentCalories = 0;
            }
            
            Console.WriteLine(maxCalories);
        }
    }
}