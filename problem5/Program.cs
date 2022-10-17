using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;


public static class DateModifier
{
    public static long GetBetweenTwoDates(string FirstDate, string SecondDate)
    {
        var first = DateTime.ParseExact(FirstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
        var second = DateTime.ParseExact(SecondDate, "yyyy MM dd", CultureInfo.InvariantCulture);

        return Math.Abs((first - second).Days);
    }
}

internal class Program
{
     static void Main(string[] args)
     {
         Console.WriteLine("enter date: yyyy MM dd");
         Console.WriteLine();
         Console.Write("First Date: ");
         string First = Console.ReadLine();
         Console.Write("Second Date: ");
         string Second = Console.ReadLine();
         Console.WriteLine("The difference in the days between them = " + DateModifier.GetBetweenTwoDates(First, Second));
     }
}
