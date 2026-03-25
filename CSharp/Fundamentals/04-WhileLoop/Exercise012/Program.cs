// Exercise012 - Random Numbers Analysis
// Write a program that generates 20 random numbers between 0 and 10,
// displays the generated values, counts how many are greater than 5,
// and how many are divisible by 3.

int count = 0;
int greaterThanFive = 0;
int divisibleByThree = 0;

Random random = new Random();

while (count < 20)
{
  int randomNumber = random.Next(0, 11);
  Console.WriteLine($"Random value #{count + 1}: {randomNumber}");

  if (randomNumber > 5)
    greaterThanFive++;

  if (randomNumber % 3 == 0)
    divisibleByThree++;

  count++;

  Console.WriteLine("\n--------------------\n");
}

Console.WriteLine($"Total numbers greater than five: {greaterThanFive}");
Console.WriteLine($"Total numbers divisible by three: {divisibleByThree}");
