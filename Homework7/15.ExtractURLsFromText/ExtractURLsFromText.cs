using System;
using System.Text.RegularExpressions;
    class ExtractURLsFromText
    {
        static void Main()
        {
            Console.WriteLine("Please enter text:");
            string text = Console.ReadLine();
            MatchCollection urls = Regex.Matches(text, @"\b(?:http://|www\.)\S+\b");
            Console.WriteLine();
            foreach (var url in urls)
            {
                Console.WriteLine(url);
            }
        }
    }
