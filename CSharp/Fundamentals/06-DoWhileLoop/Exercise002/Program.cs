// Exercise002 - Age Statistics with Do-While Loop
// Write a program that reads the ages of multiple people using a do-while loop,
// asking the user whether to continue after each entry.
// At the end, display the total number of ages entered,
// the average age, and how many people are 21 or older.

int ageCount = 0;
int totalAge = 0;
int peopleOverTwentyOne = 0;
bool shouldContinue;

do
{
  Console.Write("Enter a person's age: ");
  int currentAge = Convert.ToInt32(Console.ReadLine());
  totalAge += currentAge;
  ageCount++;

  if (currentAge >= 21)
    peopleOverTwentyOne++;

  Console.Write("Do you want to enter another age? (Y/N): ");
  char addNewPerson = Console.ReadLine().ToUpper()[0];

  shouldContinue = addNewPerson != 'N';

  Console.WriteLine("\n--------------------\n");
} while (shouldContinue);

double averageAge = (double)totalAge / ageCount;

Console.WriteLine($"You entered {ageCount} age(s)");
Console.WriteLine($"The average age is {averageAge:F1}");
Console.WriteLine($"There are {peopleOverTwentyOne} people who are 21 years old or older");
