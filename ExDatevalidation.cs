
using System;

public class ExDateValidation
{
    public static void Main()
    {
        int year, month, day;

        Console.WriteLine("Enter date in format YYYY-MM-DD:");
        string dateString = Console.ReadLine();

        if (DateTime.TryParse(dateString, out DateTime date))
        {
            if (date.Year < 2000 || date.Year > 2050)
            {
                Console.WriteLine("Invalid year. Please enter a year between 2000 and 2050.");
            }
            else if (date.Month < 1 || date.Month > 12)
            {
                Console.WriteLine("Invalid month. Please enter a month between 1 and 12.");
            }
            else if (date.Day < 1 || date.Day > DateTime.DaysInMonth(date.Year, date.Month))
            {
                Console.WriteLine("Invalid day. Please enter a day between 1 and " + DateTime.DaysInMonth(date.Year, date.Month) + ".");
            }
            else
            {
                Console.WriteLine("Valid date.");
            }
        }
        else
        {
            Console.WriteLine("Invalid date format. Please enter a date in the format YYYY-MM-DD.");
        }
    }
}
