// Exercise006 - Military Enlistment Status
// Write a program that reads a person's birth year and determines their
// military enlistment status. If the person is under 18, show how many
// years remain until enlistment. If over 18, show how many years have
// passed since the enlistment age.

Console.Write("Enter your birth year: ");
int birthYear = Convert.ToInt32(Console.ReadLine());

int age = DateTime.Now.Year - birthYear;
Console.WriteLine($"You are {age} years old.");

if (age < 18)
{
  Console.WriteLine("You are not eligible for military enlistment yet.");
  Console.WriteLine($"You have {18 - age} year(s) remaining until enlistment age.");
}
else if (age > 18)
{
  Console.WriteLine("You are past the military enlistment age.");
  Console.WriteLine($"It has been {age - 18} year(s) since you reached the enlistment age.");
}
else
{
  Console.WriteLine("You are at the required age for military enlistment.");
  Console.WriteLine("You should enlist this year.");
}

