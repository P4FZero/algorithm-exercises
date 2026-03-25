// Exercise014 - Age Statistics Analysis
// Write a program that reads the ages of 10 people and calculates
// the average age, counts how many are over 18 and under 5,
// and determines the highest age entered.

int count = 0;

double totalAge = 0;
int overEighteen = 0;
int underFive = 0;
int highestAge = int.MinValue;

while (count < 10)
{
  Console.Write($"Enter age #{count + 1}: ");
  int userInput = Convert.ToInt32(Console.ReadLine());

  totalAge += userInput;

  if (userInput > 18)
    overEighteen++;

  if (userInput < 5)
    underFive++;

  if (userInput > highestAge)
    highestAge = userInput;

  Console.WriteLine("\n--------------------\n");

  count++;
}

double averageAge = totalAge / count;

Console.WriteLine($"Average age: {averageAge:F1}");
Console.WriteLine($"Number of people over 18: {overEighteen}");
Console.WriteLine($"Number of people under 5: {underFive}");
Console.WriteLine($"Highest age entered: {highestAge}");
