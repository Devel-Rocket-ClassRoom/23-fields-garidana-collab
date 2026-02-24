using System;
using System.Collections.Generic;
using System.Text;

class Schedule
{
    public static string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

    public static void PrintWeekDays()
    {
        Console.WriteLine($"{string.Join(" ", days)}");
    }
}