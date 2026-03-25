// Exercise010 - Sum of Multiple Inputs
// Write a program that reads 7 integer values from the user
// and calculates the total sum of these numbers.

int count = 0;
int sum = 0;

while (count < 7)
{
  Console.Write($"Enter number #{count + 1}: ");
  int userInput = Convert.ToInt32(Console.ReadLine());
  sum += userInput;
  count++;

  Console.WriteLine("\n-------------------\n");
}

Console.WriteLine($"The total is: {sum}");
