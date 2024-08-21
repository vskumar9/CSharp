// C# TimeOnly
// Summary: in this tutorial, you will learn about the C# TimeOnly type and how to use it to manage time-only data effectively.

// Introduction to the C# TimeOnly type
// .NET 6 introduced the TimeOnly type that represents a time-of-day value. The TimeOnly type has a range from 00:00:00.0000000 – 23:59:59.9999999.

// To create a new TimeOnly object, you use one of its constructors. For example, the following creates a TimeOnly object with hour, minute, and second that represents 15:30:20 :

var t = new TimeOnly(15, 30, 20);
// Code language: C# (cs)
// Once having the TimeOnly instance, you can access the Hour, Minute, and Second properties:

using static System.Console;

var t = new TimeOnly(15, 30, 20);

WriteLine(t.Hour);
WriteLine(t.Minute);
WriteLine(t.Second);
// Code language: C# (cs)
// Output:

// 15
// 30
// 20
// Code language: C# (cs)
// Note that the TimeOnly constructor has overloads that also accept milliseconds and microseconds.

// If you have a DateTime object, you can convert it to a TimeOnly object by calling the FromDateTime static method of the TimeOnly object:

using static System.Console;

var t = TimeOnly.FromDateTime(DateTime.Now);

WriteLine(t);
// Code language: C# (cs)
// Output:

// 9:43 AM
// Code language: C# (cs)
// Note that your output will depend on the time you run the program.

// Like a DateTime type, the TimeOnly has the Parse() and ParseExact() static methods that parse a string into a TimeOnly instance. For example:

using static System.Console;

var t = TimeOnly.Parse("10:20:30");

WriteLine(t);
// Code language: C# (cs)
// Output:

// 10:20 AM
// Code language: C# (cs)
// Adjusting time
// Once having a TimeOnly instance, you can adjust it using the AddHours, AddMinutes, and Add methods.

// Adding or subtracting hours
// The AddHours method takes an integer and adjusts the hour of the TimeOnly instance accordingly. The following example uses the AddHours() method to add two hours to a time:

using static System.Console;

var t = TimeOnly.Parse("10:20:30");
t = t.AddHours(2);

WriteLine(t);
// Code language: C# (cs)
// Output:

// 12:20 PM
// Code language: C# (cs)
// To subtract hours from time, you can use a negative value in the AddHours() method. For example, the following uses the AddHours() method to subtract three hours from a time:

using static System.Console;

var t = TimeOnly.Parse("10:20:30");
t = t.AddHours(-3);

WriteLine(t);
// Code language: C# (cs)
// Output:

// 7:20 AM
// Code language: C# (cs)
// Adding or subtracting minutes
// The AddMinutes() method adds or subtracts minutes from a time. For example:

using static System.Console;

var t = TimeOnly.Parse("10:20:30");

// Add 10 minutes
t = t.AddMinutes(10);
WriteLine(t);

// Subtract 30 minutes
t = t.AddMinutes(-30);
WriteLine(t);
// Code language: C# (cs)
// Output:

// 10:30 AM
// 10:00 AM
// Code language: C# (cs)
// Adding or subtracting a timestamp
// The Add() method adds a timestamp to or subtracts a timestamp from a time. The following example illustrates how to add a timestamp of 2 hours 40 minutes 0 seconds to a TimeOnly object:

using static System.Console;

var t = TimeOnly.Parse("10:20:30");

// Add a timestamp 2 hours, 40 minutes, 0 seconds
t = t.Add(new TimeSpan(2,40,0));

WriteLine(t);
// Code language: C# (cs)
// Output:

// 1:00 PM
// Code language: C# (cs)
// Comparing time
// To compare two TimeOnly instances, you can use the >, >=, <, <=, and == operators. For example:

using static System.Console;

var t1 = new TimeOnly(12, 30, 0);
var t2 = new TimeOnly(12, 40, 0);

if (t1 < t2)
{
    WriteLine("t1 is before t2");
}
else
{
    WriteLine("t1 is after t2");
}
// Code language: C# (cs)
// Output:

// t1 is before t2
// Code language: C# (cs)
// Formatting time
// The TimeOnly provides you with two useful methods for formatting times including ToShortTimeString and ToLongTimeString:

using static System.Console;

var t1 = new TimeOnly(12, 30, 15);


WriteLine(t1.ToLongTimeString());
WriteLine(t1.ToShortTimeString());
// Code language: C# (cs)
// Output:

// 12:30:15 PM
// 12:30 PM
// Code language: C# (cs)
// Alternatively, you can use the format specifiers to format time. For example:

using static System.Console;

var t = new TimeOnly(14, 30, 15);

WriteLine(t.ToString("hh:mm:ss tt"));
WriteLine(t.ToString("HH:mm:ss"));
// Code language: C# (cs)
// Output:

// 02:30:15 PM
// 14:30:15
// Code language: C# (cs)
// In this example, we use the following format specifiers:

// HH: Two-digit hours in 24-hour format (e.g., 00 to 23).
// mm: Two-digit minutes (e.g., 00 to 59).
// ss: Two-digit seconds (e.g., 00 to 59).
// hh: Two-digit hours in 12-hour format (e.g., 01 to 12).
// tt: AM/PM designator.
// TimeOnly vs. DateTime
// The following table illustrates the differences between TimeOnly and DateTime types:

// Feature	TimeOnly	DateTime
// Represents	Time of day	Date and time
// Range	00:00:00.0000000 - 23:59:59.9999999	Safer to use for time-of-day values
// Serialization	Serializes less data	Serializes more data
// Type safety	feature	This can lead to OutOfRange exceptions if used for time-of-day values
// Use cases	This can lead to OutOfRange exceptions if used for time-of-day values.	When you need to represent both the date and time.
// Summary
// Use the C# TimeOnly to represent a time of the day.