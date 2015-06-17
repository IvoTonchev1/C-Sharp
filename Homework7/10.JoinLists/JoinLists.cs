using System;
using System.Collections.Generic;
using System.Linq;
    class JoinLists
    {
        static void Main()
        {
            List<string> firstList = new List<string>();
            List<string> secondList = new List<string>();
            Console.Write("Enter first list of numbers: ");
            string first = Console.ReadLine();
            Console.Write("Enter second list of numbers: ");
            string second = Console.ReadLine();
            firstList = first.Split(' ').ToList();
            secondList = second.Split(' ').ToList();
            List<int> newFirstList = new List<int>();
            List<int> newSecondList = new List<int>();
            for (int i = 0; i < firstList.Count; i++)
            {
                newFirstList.Add(int.Parse(firstList[i]));
            }
            for (int j = 0; j < secondList.Count; j++)
            {
                newSecondList.Add(int.Parse(secondList[j]));
            }
            List<int> result = new List<int>(newFirstList);
            result.AddRange(newSecondList);
            result.Sort();
            List<int> newResult = result.Distinct().ToList();
            Console.WriteLine(String.Join(" ", newResult));
        }
    }
