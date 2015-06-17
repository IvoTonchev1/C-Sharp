using System;
    class NumberAsWords
    {
        static string UppercaseFirst(string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }
        static void Main()
        {
            Console.Write("Please enter integer between 0 and 999 : ");
            int number = int.Parse(Console.ReadLine());
            string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tys = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string numberAsWord = "";
            if((number > 999) || (number < 0))
            {
                Console.WriteLine("Invalid number!");
            }   
            else if (number < 10)
            {
                numberAsWord = ones[number];
            }
            else if ((number > 9) && (number < 20))
            {
                numberAsWord = teens[(number % 10)];
            }
            else if ((number > 19) && (number < 100))
            {
                if (number % 10 == 0)
                {
                    numberAsWord = UppercaseFirst(tys[(number / 10) - 2]);
                }
                else
                {
                    numberAsWord = UppercaseFirst(tys[(number / 10) - 2]) + " " + ones[number % 10];
                }
            }
            else if (number > 99)
            {
                if ((number % 10) != 0)
                {
                    if (((number / 10) % 10) > 1)
                    {
                        numberAsWord = UppercaseFirst(ones[number / 100]) + " hundred and " + tys[(((number / 10) % 10) - 2)] + " " + ones[(number % 10)];
                    }
                    else if (((number / 10) % 10) == 1)
                    {
                        numberAsWord = UppercaseFirst(ones[number / 100]) + " hundred and " + teens[((number % 100) % 10)];
                    }
                    else if (((number / 10) % 10) == 0)
                    {
                        numberAsWord = UppercaseFirst(ones[number / 100]) + " hundred and " + ones[(number % 100)];
                    }
                }
                else
                {
                    if (((number / 10) % 10) > 1)
                    {
                        numberAsWord = UppercaseFirst(ones[number / 100]) + " hundred and " + tys[(((number / 10) % 10) - 2)];
                    }
                    else if (((number / 10) % 10) == 1)
                    {
                        numberAsWord = UppercaseFirst(ones[number / 100]) + " hundred and " + teens[((number % 100) % 10)];
                    }
                    else if (((number / 10) % 10) == 0)
                    {
                        numberAsWord = UppercaseFirst(ones[number / 100]) + " hundred"; 
                    }
                }
            }
            Console.WriteLine(number + " --> " + numberAsWord);
        }
    }