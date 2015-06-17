using System;
using System.Collections.Generic;
using System.Linq;
    class LongestWordInText
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> words = new List<string>();
            words = input.Split(' ').ToList();
            int result = 0;
            int count = 0;
            string temp = null;
            for (int i = 0; i < words.Count; i++)
            {
                count = words[i].Count();
                if (count > result)
                {
                    result = count;
                    temp = words[i];
                }
            }
            Console.WriteLine(temp);
        }
    }
