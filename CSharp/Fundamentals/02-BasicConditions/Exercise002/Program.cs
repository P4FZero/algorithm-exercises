// Exercise002 - Voting Eligibility Check
// Write a program that reads a person's birth year, calculates their age,
// and determines whether they are eligible to vote.

Console.Write("Please enter your birth year: ");
int birthYear = Convert.ToInt32(Console.ReadLine());

int age = DateTime.Now.Year - birthYear;

if (age >= 18)
  Console.WriteLine("Since you are 18 years or older, you can vote.");
else
  Console.WriteLine("You must be at least 18 years old to vote.");
