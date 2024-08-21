// C# DateOnly
// Summary: in this tutorial, you will learn about the C# DateOnly and how to use it effectively to manage date-only data.

// Introduction to the C# DateOnly type
// .NET 6 introduced the DateOnly type that represents a specific date without a time component. Like the DateTime type, the DateOnly has a range from 0001-01-01 through 9999-12-31.

// The DateOnly type is suitable for representing a specific date such as birth date, invoice date, and expired date.

// The DateOnly is a struct so it is immutable. In other words, a DateOnly cannot be changed once it is created.

// To create a new DateOnly object, you use the following constructor:

DateOnly(int year, int month, int day);
// Code language: C# (cs)
// For example, the following creates a DateOnly object that represents January 31, 2023:

var d = new DateOnly(2023, 1, 31);
// Code language: C# (cs)
// The DateOnly object has the Year, Month, and Day properties that represent the year, month, and day of the date:

using static System.Console;

var d = new DateOnly(2023, 1, 31);

WriteLine(d.Year);
WriteLine(d.Month);
WriteLine(d.Day);
// Code language: C# (cs)
// Output:

// 2023
// 1
// 31
// Code language: C# (cs)
// Also, you can use the Parse() static method of the DateOnly class to parse a date string into a DateOnly instance.

// For example, the following parses the string "2023-01-31" into a DateOnly instance:

var d = DateOnly.Parse("2023-01-31");
// Code language: C# (cs)
// DateOnly operations
// Once having a DateOnly object, you can use it to perform various operations such as comparing two DateOnly objects, adding or subtracting days, months, or years from a DateOnly object, and formatting a DateOnly object as a string.

// Comparing two DateOnly objects
// The following example illustrates how to compare two DateOnly objects:

using static System.Console;

var d1 = DateOnly.Parse("2023-01-31");
var d2 = DateOnly.Parse("2023-01-30");

if (d1 < d2)
{
    WriteLine($"{d1} is ealier than {d2}");
}
else
{
    WriteLine($"{d1} is after than {d2}");
}
// Code language: C# (cs)
// Output:

// 1/31/2023 is after than 1/30/2023
// Code language: C# (cs)
// Adding or subtracting days, months, or years from a DateOnly instance
// The following example illustrates how to add 7 days to a DateOnly object:

using static System.Console;

var d = new DateOnly(2023, 1, 31);
var sevenDaysLater = d.AddDays(7);

WriteLine(sevenDaysLater.ToString());
// Code language: C# (cs)
// Output:

// 2/7/2023
// Code language: C# (cs)
// To subtract the number of days from a DateOnly object, you also use the AddDays() method but pass a negative number like this:

using static System.Console;

var d = new DateOnly(2023, 1, 31);
var sevenDaysBefore = d.AddDays(-7);

WriteLine(sevenDaysBefore.ToString());
// Code language: C# (cs)
// Output:

// 1/24/2023
// Code language: C# (cs)
// Since the AddDays(), AddMonths(), and AddYears() methods return a DateOnly object, you can chain them together.

// For example, the following add 2 months and 1 year to a DateOnly object:

using static System.Console;

var d = new DateOnly(2023, 1, 31);
var newDate= d.AddMonths(2).AddYears(1);

WriteLine(newDate.ToString());
// Code language: C# (cs)
// Output:

// 3/31/2024
// Code language: C# (cs)
// Formatting a DateOnly object as a string
// The following format a DateOnly object as a string:

using static System.Console;

var d = new DateOnly(2023, 1, 31);

WriteLine(d.ToString("D"));
// Code language: C# (cs)
// Output:

// Tuesday, January 31, 2023
// Code language: C# (cs)
// In this example, we use the “D” format specifier to format the DateOnly object. For a comprehensive date format string, check out this page.

// DateOnly vs. Datetime
// The following table compares the DateOnly with the DateTime type:

// Feature	DateOnly	DateTime
// Represents	A date without a time component	A date and time component
// Immutable	Yes	No
// Size	8 bytes	16 bytes
// Serialization	Serializes only the date component	Serializes the date and time components
// Use cases	When you only need to represent a date, such as a birthday or a holiday	When you need to represent a date and time, such as a timestamp or a meeting time
// Summary
// Use the C# DateOnly type to work with the date-only data.