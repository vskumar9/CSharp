// C# DateTime Parse

// Summary: in this tutorial, you will learn how to use the 
// C# DateTime Parse() method to convert a string to a DateTime value.

// Introduction to C# DateTime Parse() method
// The DateTime.Parse() method converts a string representation of a date and time to a DateTime value. For example:

using static System.Console;

var dt = DateTime.Parse("05/07/2023");
WriteLine(dt.ToLongDateString());
// Output:
// Sunday, May 7, 2023

// The Parse() method converts the string 05/07/2023 to May 7, 2023, not July 5, 2023. The reason is that the Parse() method uses the current culture of the computer.

// To get the current culture, you use a CultureInfo in the second argument of the Parse() method. For example, the following use the Parse() method to parse the string 05/07/2023 but uses the en-GB culture:

using System.Globalization;
using static System.Console;

WriteLine(CultureInfo.CurrentCulture); // en-US
// Output:
// en-US

// To instruct the Parse() method to use an explicit culture, you can use a CultureInfo object as the second argument like this:
using System.Globalization;
using static System.Console;

var dt = DateTime.Parse("05/07/2023", CultureInfo.InvariantCulture);
var dt = DateTime.Parse(
    "05/07/2023",
    CultureInfo.GetCultureInfo("en-GB")
);

WriteLine(dt.ToLongDateString());


// Output:
// Wednesday, July 5, 2023

// In this example, the Parse() method parses the string 05/07/2023 as July 5, 2023.

// If the input string doesn’t have time data, the Parse() method will assume 12:00 midnight. For example:

using System.Globalization;
using static System.Console;

var dt = DateTime.Parse(
    "05/07/2023",
    CultureInfo.GetCultureInfo("en-GB")
);

WriteLine(dt);

// Output:
// 7/5/2023 12:00:00 AM

// If the Parse() method cannot parse a string to a valid DateTime value, it’ll 
// throw a FormatException exception. To avoid the exception, you can use the TryParse() method instead.



// C# DateTime TryParse()

using System.Globalization;
using static System.Console;


if (DateTime.TryParse(
    "05/07/2023 10:45:00",
    CultureInfo.GetCultureInfo("en-US"),
    out var dt
))
{
    WriteLine(dt);
}
else
{
    WriteLine("Invalid date and time string");
}

// Output:
// 5/7/2023 10:45:00 AM

// And the following example shows the failure case:

using System.Globalization;
using static System.Console;


if (DateTime.TryParse(
    "15/07/2023 10:45:00",
    CultureInfo.GetCultureInfo("en-US"),
    out var dt
))
{
    WriteLine(dt);
}
else
{
    WriteLine("Invalid date and time string");
}

// Output:
// Invalid date and time string

// Summary
// Use the C# DateTime.Parse() method to convert a date and time string to an equivalent DateTime object.
// Use the C# DateTime.TryParse() method to convert a date and time string to an equivalent DateTime object and returns false if the input string is invalid.

