// Exercise004 - Even or Odd Check
// Write a program that reads an integer and determines
// whether it is even or odd.

Console.Write("Enter an integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
  Console.WriteLine("This number is even.");
else
  Console.WriteLine("This number is odd.");
