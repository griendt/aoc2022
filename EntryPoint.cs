using System;

namespace AdventOfCode2022
{
    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                throw new ArgumentException("Please provide a problem class name as an argument.");
            }
            
            ((IProblem)Activator.CreateInstance(Type.GetType("AdventOfCode2022." + args[0], true))).Run();
        }
    }
}