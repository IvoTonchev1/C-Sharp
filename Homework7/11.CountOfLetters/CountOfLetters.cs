using System;
using System.Collections.Generic;
using System.Linq;
    class CountOfLetters
    {
        static void Main()
        {
            List<string> letters = new List<string>();
            Console.Write("Enter list of letters: ");
            string input = Console.ReadLine();
            letters = input.Split(' ').ToList();           
            var q = letters.GroupBy(x => x).Select(g => new { Value = g.Key, Count = g.Count() });
            letters.Sort();
            foreach (var x in q)
            {
                Console.WriteLine(x.Value + " -> " + x.Count);
            }
        }
    }