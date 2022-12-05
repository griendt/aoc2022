using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2022
{
    public class Problem5B : IProblem
    {
        public void Run()
        {
            var isInitializing = true;
            var stacks = new List<List<char>>();
            for (var i = 0; i < 9; i++)
            {
                stacks.Add(new List<char>());
            }

            foreach (var line in File.ReadLines("../../Input5.txt"))
            {
                if (line.StartsWith(" 1 "))
                {
                    stacks.ForEach(stack => stack.Reverse());
                    isInitializing = false;
                }

                else if (isInitializing)
                {
                    for (var i = 0; i < line.Length / 4 + 1; i++)
                    {
                        var crate = line[4 * i + 1];
                        if (crate != ' ')
                        {
                            stacks[i].Add(crate);
                        }
                    }
                }

                else if (line.Trim().Length > 0)
                {
                    var instruction = line.Split(' ');
                    var amountToMove = int.Parse(instruction[1]);
                    var source = int.Parse(instruction[3]) - 1;
                    var target = int.Parse(instruction[5]) - 1;
                    var rangeToAdd = stacks[source].GetRange(stacks[source].Count - amountToMove, amountToMove);
                    
                    stacks[target].AddRange(rangeToAdd);
                    stacks[source].RemoveRange(stacks[source].Count - amountToMove, amountToMove);
                }
            }

            Console.WriteLine(string.Join("", stacks.Select(stack => stack.LastOrDefault())));
        }
    }
}