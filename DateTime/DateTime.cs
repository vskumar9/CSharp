/*
C# DateTime
Summary: in this tutorial, you will learn how to use the C# "DateTime" 
type to work with date and time values.

Creating C# DateTime objects
The DateTime is a value type that represents dates and times with values from 
January 1, 0001, 00:00:00 (midnight) to 11:59:59 PM, December 31 9999.

To create a DateTime object, you call its constructor and pass various date and time properties such 
as year, month, day, minute, hour, and second. For example:
*/

using static System.Console;

public static void Main()
    {
        DateTime dt = DateTime.Now;
        Console.Write(dt.ToString());
        //08/21/2024 14:16:39
    }

/*

var dt = new DateTime(2023, 5, 15, 7, 0, 0);
WriteLine(dt.ToString());

Code language: C# (cs)
Output:
5/15/2024 7:00:00 AM
*/

// Accessing C# DateTime properties

// The DateTime object provides many useful properties that allow you to work with dates and times easily.

// For example, you can access Year, Month, Day, Hour, Minute, and Second via the respective properties like this:
using static System.Console;

var dt = new DateTime(2023, 5, 15, 7, 0, 0);

WriteLine(dt.Year);
WriteLine(dt.Month);
WriteLine(dt.Day);
WriteLine(dt.Hour);
WriteLine(dt.Minute);
WriteLine(dt.Second);

/*
Output:

2023
5
15
7
0
0
*/

// To get the current local time, you can use the DateTime.Now property. For example:
var dt = DateTime.Now;
WriteLine(dt.ToString());

/*
Formatting C# DateTime values
The format of the date and time depends on many factors such as culture, 
international standards, and personal preference.

By default, the ToString() method of the DateTime object 
returns the string representation of a date and time value 
based on the current culture’s short-date and long-time pattern. For example:
*/

using static System.Console;
var dt = new DateTime(2023, 5, 15, 7, 0, 0);
WriteLine(dt.ToString());

/*
Output:
5/15/2023 7:00:00 AM
*/

// To ToString() method has many overloads that allow you to customize the representation of the date and time value.
// For example, 
// you can use the "d" and "D" format specifier to 
// format a DateTime object using the short and long date pattern:

using static System.Console;

var dt = new DateTime(2023, 5, 15, 7, 0, 0);

WriteLine(dt.ToString("d")); // 5/15/2023
WriteLine(dt.ToString("D")); // Monday, May 15, 2023

/*
Output:

5/15/2023
Monday, May 15, 2023
*/

/********** 
DateTime Formate
Link: https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
**********/

// Performing DateTime Calculations
/*
To return a new DateTime that adds a specified number of years, months, days, hours, minutes, and seconds to a value of a DateTime instance, you use the AddYears, AddMonths, AddDays, AddHours, AddMinutes, AddSeconds methods.

For example, the following program shows how to use the AddYears() method to add one year to a DateTime instance:
*/
using static System.Console;

var dt = new DateTime(2023, 5, 15, 7, 0, 0);

// add one year
var dt2 = dt.AddYears(1);

WriteLine(dt2);

// Output:
// 5/15/2024 7:00:00 AM

// Because the Add* method returns a new instance of the DateTime, you can chain the Add* methods like this:
using static System.Console;

var dt = new DateTime(2023, 5, 15, 7, 0, 0);

// add 1 year, 2 months, 3 days, and 4 hours
var dt2 = dt.AddYears(1)
            .AddMonths(2)
            .AddDays(3)
            .AddHours(4);

WriteLine(dt2);

// Output:
// 7/18/2024 11:00:00 AM

// Notice that to subtract a specified number of years, months, days, hours, minutes, and seconds from a DateTime instance, you can use the Add* methods but use a negative value. For example:

using static System.Console;

var dt = new DateTime(2023, 5, 15, 7, 0, 0);

// subtract 1 year
var dt2 = dt.AddYears(-1);
WriteLine(dt2);

// Output:
// 5/15/2022 7:00:00 AM

// To calculate the time interval between two DateTime values, you can use the Subtract method. For example:

using static System.Console;

var dt1 = new DateTime(2023, 5, 15);
var dt2 = new DateTime(2022, 5, 15);


var interval = dt1.Subtract(dt2);
Console.WriteLine(interval.Days); // 365

// In this example, we created two DateTime objects and use the Subtract() method to subtract the second DateTime object from the first one.

// The return value of the Subtract() method is a time interval with the type TimeSpan. And finally, we display the number of days of the timespan on the console.

// Summary
// Use C# DateTime type to work with date and time values.
// Use the Add* methods to add a specified number of years, months, days, hours,
// minutes, and seconds to a DateTime instance.
// Use the Subtract method to calculate the time interval between two DateTime values.
