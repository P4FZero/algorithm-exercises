// Exercise005 - Leap Year Check
// Write a program that reads a given year and determines
// whether it is a leap year according to the Gregorian calendar rules.

Console.Write("Enter a year: ");
int year = Convert.ToInt32(Console.ReadLine());

bool isLeapYear = false;

if (year % 4 == 0)
{
  if (year % 100 == 0)
  {
    if (year % 400 == 0)
      isLeapYear = true;
  }
  else
    isLeapYear = true;
}

if (isLeapYear)
  Console.WriteLine($"The year {year} is a leap year.");
else
  Console.WriteLine($"The year {year} is not a leap year.");
