using System;
using System.Globalization;
using System.Threading;
    class BeerTime
    {
        static void Main()
        {
            CultureInfo enUS = new CultureInfo("en-US");
            Console.WriteLine("Please enter time: ");
            string givenTime = Console.ReadLine();
            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");
            DateTime time;
            if(DateTime.TryParseExact(givenTime, "h:mm tt", enUS, DateTimeStyles.None, out time))
            {
                if((time >= startTime) || (time < endTime))
                {
                    Console.WriteLine("Beer time!");
                }
                else
                {
                    Console.WriteLine("Non-beer time.");
                }
            }
            else
            {
                Console.WriteLine("Invalid time!");
            }

        }
    }
