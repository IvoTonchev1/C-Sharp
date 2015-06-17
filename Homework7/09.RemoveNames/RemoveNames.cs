using System;
using System.Collections.Generic;
using System.Linq;
    class RemoveNames
    {
        static void Main()
        {
            List<string> firstList = new List<string>();
            List<string> secondList = new List<string>();
            Console.Write("Enter first list of names: ");
            string first = Console.ReadLine();
            Console.Write("Enter second list of names: ");
            string second = Console.ReadLine();
            firstList = first.Split(' ').ToList();
            secondList = second.Split(' ').ToList();
            Console.WriteLine();
            foreach (string name in secondList)
            {
                bool temp = true;
                foreach (string newname in firstList)
                {
                    if (newname == name)
                    {
                        temp = false;
                    }
                }
                if (!temp)
                {
                    firstList.RemoveAll(item => item == name);
                }
            }
            Console.WriteLine(String.Join(" ", firstList));
        }
    }
