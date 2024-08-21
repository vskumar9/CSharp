// C# DateTimeOffset
// Summary: in this tutorial, you’ll learn how to use the C# DateTimeOffset to handle date and time values with the time zone offset.

// Introduction to the C# DateTimeOffset type
// C# DateTimeOffset represents a date and time value that consists of two components:

// The DateTime represents the date and time.
// The offset represents the difference between the local time and UTC.
// The offset is expressed as the number of hours and minutes ahead or behind UTC:

+HH:MM
// Code language: CSS (css)
// Or

-HH:MM
// Code language: CSS (css)
// For example:

5/15/2023 10:46:09 AM -07:00
// In this DateTimeOffset example, the DateTime component is 5/15/2023 10:46:09 AM and the offset component is -07:00.

// Creating a DateTimeOffset value
// To create a DateTimeOffset object, you use the DateTimeOffset‘s constructor and initialize it with a DateTime value and an offset. For example:

using static System.Console;

var dateTimeOffset = new DateTimeOffset(
    new DateTime(2023, 5, 15, 7, 0, 0),
    new TimeSpan(-7, 0, 0)
);

WriteLine(dateTimeOffset);
// Code language: C# (cs)
// Output:

// 5/15/2023 7:00:00 AM -07:00
// Code language: C# (cs)
// In this example, we use TimeSpan to create an offset for the DateTimeOffset object.

// To get the current date and time with a time zone offset, you can use the Now property:

using static System.Console;

WriteLine(DateTime.Now);
WriteLine(DateTimeOffset.Now);
// Code language: CSS (css)
// Output:

// 5/15/2023 10:46:09 AM
// 5/15/2023 10:46:09 AM -07:00
// Accessing DateTimeOffset properties
// The DateTimeOffset has many useful properties including Year, Month, Day, Hour, Minute and Second, and Offset:

using static System.Console;

var dateTimeOffset = new DateTimeOffset(
    new DateTime(2023, 5, 15, 7, 0, 0),
    new TimeSpan(-7, 0, 0)
);

// year, month, day, hour, minute, and second 
WriteLine(dateTimeOffset.Year);
WriteLine(dateTimeOffset.Month);
WriteLine(dateTimeOffset.Day);
WriteLine(dateTimeOffset.Hour);
WriteLine(dateTimeOffset.Minute);
WriteLine(dateTimeOffset.Second);

// offset
WriteLine(dateTimeOffset.Offset);
// Code language: JavaScript (javascript)
// Using the DateTimeOffset to find the current timezone
// The following example shows how to use the DateTimeOffset and TimeZoneInfo to find the current timezone of the system and display them on the console:

using static System.Console;

var time = DateTimeOffset.Now;

// find the timezone
foreach (var timezone in TimeZoneInfo.GetSystemTimeZones())
{
    if (timezone.GetUtcOffset(time) == time.Offset)
    {
        WriteLine(timezone);
    }
}
// Code language: C# (cs)
// The program show displays a list of current timezones.

// How it works:

// Define a variable time and initialize it to the DateTimeOffset.Now property. The time represents the current date and time, including the time zone offset.
// Iterate over all the time zones available on the system using the GetSystemTimeZones method. Inside the loop, check if the current timezone’s UTC offset is the same as the offset of the time object using the GetUtcOffset() method.
// If the time zone’s offset matches the time object’s offset, then it means the current time zone is one that we’re looking for and displays it to the console.
// Summary
// Use the C# DateTimeOffset when you need to work with time zones and represent the same point in time across multiple time zones.
