using System;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class Problem1B : IProblem
    {
        public void Run()
        {
            int[] calories = { 0, 0, 0 };
            var lowestCalories = 0;
            var currentCalories = 0;

            foreach (var line in File.ReadLines("../../Input1.txt"))
            {
                if (line.Length != 0)
                {
                    currentCalories += int.Parse(line);
                    continue;
                }

                if (currentCalories > lowestCalories)
                {
                    for (var i = 0; i < 3; i++)
                    {
                        if (calories[i] != lowestCalories) continue;
                        calories[i] = currentCalories;
                        lowestCalories = calories.Min();
                        break;
                    }
                }

                currentCalories = 0;
            }

            Console.WriteLine(calories.Sum());
        }
    }
}
