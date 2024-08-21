// C# TimeSpan
// Summary: in this tutorial, you’ll learn how to use the C# TimeSpan to represent a time interval.

// Introduction to the C# TimeSpan type
// The TimeSpan represents a time interval or time duration. In practice, you use a TimeSpan to represent the difference between two dates (DateTime). For example:

using static System.Console;

var start = new DateTime(2023, 5, 15, 10, 0, 0);
var end = new DateTime(2023, 5, 15, 10, 30, 0);

var duration = end - start;

WriteLine(duration); // 00:30:00
// Code language: C# (cs)
// In this example, we initialize the start and end variables and calculate the difference between end and start. The result is a TimeSpan that represents a duration of 30 minutes.

// Creating a TimeSpan objects
// To create a TimeSpan object, you use its constructor. The TimeSpan constructor has some overloads:

TimeSpan()
TimeSpan(int hours, int minutes, int seconds)
TimeSpan(int days, int hours, int minutes, int seconds)
TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
TimeSpan(long ticks)
// Code language: C# (cs)
// For example:

using static System.Console;

// Creates a TimeSpan object with default value (0 ticks).
var ts1 = new TimeSpan();
WriteLine(ts1); // 00:00:00


// Creates a TimeSpan object with a value of 1 hour.
var ts2 = new TimeSpan(1, 0, 0);
WriteLine(ts2); // 01:00:00

// Creates a TimeSpan object with a value of 30 minutes.
var ts3 = new TimeSpan(0, 30, 0);
WriteLine(ts3); // 00:30:00

// Creates a TimeSpan object with a value
// of 2 hours, 30 minutes and 10 seconds.
var ts4 = new TimeSpan(2, 30, 10);
WriteLine(ts4); // 02:30:10
// Code language: C# (cs)
// Output:

// 00:00:00
// 01:00:00
// 00:30:00
// 02:30:10
// Code language: C# (cs)
// Accessing the C# TimeSpan properties
// The TimeSpan class provides several read-only properties to retrieve the components of a TimeSpan object:

using static System.Console;

var timeSpan = new TimeSpan(7, 2, 30, 45, 750);

// Retrieving the days 
var days = timeSpan.Days;
WriteLine(days);

// Retrieving the hours 
var hours = timeSpan.Hours;
WriteLine(hours);

// Retrieving the minutes 
var minutes = timeSpan.Minutes;
WriteLine(minutes);

// Retrieving the seconds 
var seconds = timeSpan.Seconds;
WriteLine(seconds);

// Retrieving the milliseconds 
var milliseconds = timeSpan.Milliseconds;
WriteLine(milliseconds);

// Retrieving the total number of days
var totalDays = timeSpan.TotalDays;
WriteLine(totalDays);

// Retrieving the total number of hours
var totalHours = timeSpan.TotalHours;
WriteLine(totalHours);

// Retrieving the total number of minutes
var totalMinutes = timeSpan.TotalMinutes;
WriteLine(totalMinutes);

// Retrieving the total number of seconds
var totalSeconds = timeSpan.TotalSeconds;
WriteLine(totalSeconds);

// Retrieving the total number of milliseconds
var totalMilliseconds = timeSpan.TotalMilliseconds;
WriteLine(totalMilliseconds);
// Code language: C# (cs)
// Output:

// 7
// 2
// 30
// 45
// 750
// 7.104696180555556
// 170.51270833333334
// 10230.7625
// 613845.75
// 613845750
// Code language: C# (cs)
// Getting the total time span
// The TimeSpan class provides various methods to get the total time span in different units like ticks, milliseconds, seconds, minutes, hours, and days. For example:

using static System.Console;

// Creates a TimeSpan object with a value of 1 day, 30 hours,
// 30 minutes, 30 seconds, and 500 milliseconds.
var ts = new TimeSpan(1, 30, 30, 30, 500);

// Gets the total number of ticks.
var ticks = ts.Ticks;
WriteLine(ticks);

// Gets the total number of days.
var days = ts.Days;
WriteLine(days);

// Gets the total number of hours.
var hours = ts.Hours;
WriteLine(hours);

// Gets the total number of minutes.
var minutes = ts.Minutes;
WriteLine(minutes);

// Gets the total number of seconds.
var seconds = ts.Seconds;
WriteLine(seconds);

// Gets the total number of milliseconds.
var milliseconds = ts.Milliseconds;
WriteLine(milliseconds);
// Code language: C# (cs)
// Output:

// 1962305000000
// 2
// 6
// 30
// 30
// 500
// Code language: C# (cs)
// Performing arithmetic operations on C# TimeSpan
// To perform arithmetic operations on time such as addition, subtraction, multiplication, and division, you use the respective methods of the TimeSpan object. For example:

using static System.Console;

// Creates a TimeSpan object with a value of 1 hour.
var ts1 = new TimeSpan(1, 0, 0);

// Creates a TimeSpan object with a value of 30 minutes.
var ts2 = new TimeSpan(0, 30, 0);


// Adds ts2 to ts1.
var ts3 = ts1.Add(ts2);
WriteLine(ts3); // 01:30:00

// Subtracts ts2 from ts1.
var ts4 = ts1.Subtract(ts2);
WriteLine(ts4); // 00:30:00


// Multiplies ts1 by 2.
var ts5 = ts1.Multiply(2);
WriteLine(ts5); // 02:00:00

var ts6 = ts5.Divide(2);
WriteLine(ts6); // 01:00:00
// Code language: C# (cs)
// Output:

// 01:30:00
// 00:30:00
// 02:00:00
// 01:00:00
// Code language: C# (cs)
// Comparing C# TimeSpan object
// The TimeSpan class provides operator overloads like greater than >, equal =, less than <, and not equal != to compare time spans:

using static System.Console;

// Creates a TimeSpan object with a value of 1 hour.
var ts1 = new TimeSpan(1, 0, 0);

// Creates a TimeSpan object with a value of 30 minutes.
var ts2 = new TimeSpan(0, 30, 0);

// ts1 is greater than ts2 -> true
var result1 = ts1 > ts2;
WriteLine(result1);

// ts1 is less than ts2 -> false
var result2 = ts1 < ts2;
WriteLine(result2);

// ts1 is equal to ts2 -> false
var result3 = ts1 == ts2;
WriteLine(result3);

// ts1 is not equal to ts2 -> true
var result4 = ts1 != ts2;
// WriteLine(result4);
// Code language: C# (cs)
// Output:

// True
// False
// False
// True
// Code language: PHP (php)
// Summary
// Use C# TimeSpan to represent a time interval.