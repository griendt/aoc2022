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
            var lines = File.ReadLines("../../Input1A.txt");
            
            foreach (var line in lines)
            {
                if (line.Length == 0)
                {
                    maxCalories = Math.Max(maxCalories, currentCalories);
                    currentCalories = 0;
                }
                else
                {
                    currentCalories += int.Parse(line);
                }
            }
            
            Console.WriteLine(maxCalories);
        }
    }
}