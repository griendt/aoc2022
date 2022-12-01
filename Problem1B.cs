using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode2022
{
    public class Problem1B : IProblem
    {
        public void Run()
        {
            var calories = new List<int>();
            var currentCalories = 0;
            var lines = File.ReadLines("../../Input1A.txt");

            foreach (var line in lines)
            {
                if (line.Length == 0)
                {
                    calories.Add(currentCalories);
                    currentCalories = 0;
                }
                else
                {
                    currentCalories += int.Parse(line);
                }
            }
            
            calories.Sort();
            Console.WriteLine(calories[calories.Count -1] + calories[calories.Count -2] + calories[calories.Count -3]);
        }
    }
}