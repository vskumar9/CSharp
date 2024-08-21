// Summary: 
// in this tutorial, you will learn how to use the C# DateTime 
// ParseExact() method to convert a string to a DateTime object with the exact matched format.

// Introduction to the C# DateTime ParseExact() method

// If you have a date and time string with a specified format, you can convert it to a DateTime object using the ParseExact() method:

public static DateTime ParseExact (
   string s, 
   IFormatProvider? provider, 
   System.Globalization.DateTimeStyles styles
);

// The ParseExact() method takes three parameters:

// string s: The string representation of the date and time to convert.
// IFormatProvider? provider: An optional IFormatProvider object that specifies the culture-specific format information used to interpret the date and time string. If null, the method uses the default format provider for the current culture.
// System.Globalization.DateTimeStyles styles: A DateTimeStyles value that specifies any additional style information to use when interpreting the date and time string. For example, you can specify whether to allow leading/trailing white space, 
// whether to allow a date to have no year, or whether to allow a time to have no seconds.

// For example:
using System.Globalization;
using static System.Console;

var s = "05/07/2023";

var dt = DateTime.ParseExact(
    s,
    "M/d/yyyy",
    CultureInfo.InvariantCulture);

WriteLine(dt.ToLongDateString()); // Sunday, May 7, 2023


// In this example, we use the ParseExact() method to convert the date string "05/07/2023" to a DateTime with the format M/d/yyyy.

// The ParseExact() accepts three arguments:

// s is the input string that represents a date and time.
// "M/d/yyyy" is the specified format for parsing the input string s.
// CultureInfo.InvariantCulture is the culture for parsing the input string. The CultureInfo.InvariantCulture means culture-independent.
// For a complete list of custom date and time format specifiers, please check out this page.

// Sometimes, the date string may have one or many possible formats. To match a date string with multiple possible formats, 
// you can pass an array of formats to the second argument of the ParseExact method like this:

public static DateTime ParseExact (
   string s, 
   string[] formats, 
   IFormatProvider? provider, 
   System.Globalization.DateTimeStyles style
);

// For example:

using System.Globalization;
using static System.Console;

var s = "15/07/2023";
string[] formats = { "M/d/yyyy", "d/M/yyyy" };
var culture = CultureInfo.InvariantCulture;
var style = DateTimeStyles.None;

try
{
    var dt = DateTime.ParseExact(s, formats, culture, style);
    WriteLine("Converted '{0}' to {1}.", s, dt);
}
catch (FormatException)
{
    WriteLine("Unable to convert '{0}'.", s);
}

// In this example, we have a string s that represents a date in the format 15/07/2023. We want to convert this string to its corresponding DateTime object, but we don’t know which format the date is in.

// To handle this situation, we call the DateTime.ParseExact() method with multiple formats specified in the formats array. In this case, we have two expected formats: "M/d/yyyy" and "d/M/yyyy". This means that the method will try to parse the input string using both formats until it finds a match.

// If the input string s matches one of the expected formats, the method returns a DateTime value that corresponds to the parsed date and time string. If the input string doesn’t match any of the expected formats, the method throws a FormatException exception.

// In this example, the output will be:
// Converted '15/07/2023' to 7/15/2023 12:00:00 AM.

// indicating that the string has been successfully converted to a DateTime object using the "M/d/yyyy" format.

// If the ParseExact() cannot parse the input string based on the specified format, it’ll throw a FormatException exception. To avoid the exception, you can use the TryParseExact() method.

// C# DateTime TryParseExact() method

// The TryParseExact() method is the same as the ParseExact() method except that it doesn’t throw a FormatException exception if the input string is not matched with the date format specifier. Instead, it returns true if the conversion succeeds or false otherwise:

public static bool TryParseExact (
    string? s, 
    string? format, 
    IFormatProvider? provider, 
    System.Globalization.DateTimeStyles style, 
    out DateTime result
);
// Code language: C# (cs)
// The TryParseExact() takes several parameters:

// string s: The string representation of the date and time to convert.
// string format: A string that specifies the expected format of the date and time string.
// CultureInfo culture: A CultureInfo object that specifies the culture used to interpret the date and time string. This affects the interpretation of any format specifiers that use culture-sensitive information, such as the day of the week or the month name.
// DateTimeStyles styles: A DateTimeStyles value that specifies any additional style information to use when interpreting the date and time string. For example, you can specify whether to allow leading/trailing white space, whether to allow a date to have no year, or whether to allow a time to have no seconds.
// out DateTime result: An out parameter that receives the DateTime value that corresponds to the parsed date and time string if the conversion is successful.
// The following example shows how to use the TryParseExact() method to parse a date string using a list of formats:

using System.Globalization;
using static System.Console;

var s = "15/07/2023";
var formats = new string[] { "M/d/yyyy", "d/M/yyyy" };
var culture = CultureInfo.InvariantCulture;
var style = DateTimeStyles.None;

foreach (var format in formats)
{
    if (DateTime.TryParseExact(s, format, culture, style, out var dt))
    {
        WriteLine(dt);
    }
    else
    {
        WriteLine($"The string {s} doesn't match the format {format}");
    }

}
// Code language: C# (cs)
// Output:

// The string 15/07/2023 doesn't match the format M/d/yyyy
// 7/15/2023 12:00:00 AM
// Code language: plaintext (plaintext)
// How it works.

// First, initialize the date string s with the value 15/07/2023, a string array formats with two different date format strings: "M/d/yyyy" and "d/M/yyyy". We’ll use these formats to parse the date string s.
// Second, declare a CultureInfo object called culture with the value InvariantCulture. It ensures that the TryParseExact will parse the date string correctly regardless of the user’s cultural settings.
// Third, define a DateTimeStyles variable called style with the value None. This specifies that the TryParseExact() won’t need any additional styles or flags when parsing the date string.
// Finally, use a foreach loop that iterates through each of the date formats in the formats array. For each format, use the DateTime.TryParseExact() method to parse the s string using the specified format, culture, and style.
// If the conversion is successful, the program writes the resulting DateTime object to the console using the WriteLine() method. Otherwise, it writes an error message to the console indicating that the string s does not match the current format.

// Summary
// Use the C# DateTime ParseExact() method to convert a string to a DateTime object with the exact matched format.
// Use the C# DateTime.TryParseExact() method to convert a string representation of a date and time to its DateTime equivalent using a specified format and culture, and returns true if the conversion was successful or false otherwise.