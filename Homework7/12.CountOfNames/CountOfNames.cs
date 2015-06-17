using System;
using System.Collections.Generic;
using System.Linq;
    class CountOfNames
    {
        static void Main()
        {
            List<string> names = new List<string>();
            Console.Write("Enter list of letters: ");
            string input = Console.ReadLine();
            names = input.Split(' ').ToList();
            var q = names.GroupBy(x => x).Select(g => new { Value = g.Key, Count = g.Count() });
            names.Sort();
            foreach (var x in q)
            {
                Console.WriteLine(x.Value + " -> " + x.Count);
            }
        }
    }
