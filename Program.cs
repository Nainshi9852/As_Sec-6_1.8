using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
            Console.ReadKey();
        }
        static void doApp()
        {
            // Get the current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + now);

            // Date manipulation
            DateTime futureDate = now.AddDays(30);
            Console.WriteLine("Date 30 days from now: " + futureDate);

            // Formatting dates
            string formattedDate = now.ToString("yyyy-MM-dd");
            Console.WriteLine("Formatted Date: " + formattedDate);

            // Parse a date from a string
            string dateString = "2023-07-27";
            DateTime parsedDate = DateTime.ParseExact(dateString, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine("Parsed Date: " + parsedDate);

            // Date comparison
            if (now > parsedDate)
            {
                Console.WriteLine("The current date is after the parsed date.");
            }
            else if (now < parsedDate)
            {
                Console.WriteLine("The current date is before the parsed date.");
            }
            else
            {
                Console.WriteLine("The current date is the same as the parsed date.");
            }

            // Difference between two dates
            TimeSpan dateDifference = futureDate - now;
            Console.WriteLine("Difference between future date and current date: " + dateDifference.Days + " days");
        }
    }
}
