// Exercise004 - Age and Gender Data Analysis
// Write a program that reads the age and gender of multiple people,
// continuing based on user input. At the end, display the highest age,
// the number of men, the age of the youngest woman,
// and the average age of the men.

int highestAge = int.MinValue;
int totalMen = 0;
int youngestWomanAge = int.MaxValue;
int totalMenAge = 0;

while (true)
{
  Console.Write("Enter the person's age: ");
  int personAge = Convert.ToInt32(Console.ReadLine());

  Console.Write("Enter the person's gender (M/F): ");
  char personGender = Console.ReadLine().ToUpper()[0];

  if (personAge > highestAge)
    highestAge = personAge;

  if (personGender == 'M')
  {
    totalMenAge += personAge;
    totalMen++;
  }
  else if (personGender == 'F')
  {
    if (personAge < youngestWomanAge)
      youngestWomanAge = personAge;
  }

  Console.Write("Do you want to enter another person? (Y/N): ");
  char newEntry = Console.ReadLine().ToUpper()[0];

  if (newEntry == 'N')
  {
    Console.WriteLine("Updating statistics...\n");
    break;
  }

  Console.WriteLine("\n--------------------\n");
}

double averageMenAge = totalMen > 0 ? (double)totalMenAge / totalMen : 0;

Console.WriteLine($"Highest age entered: {highestAge}");
Console.WriteLine($"Total number of men: {totalMen}");
Console.WriteLine($"Age of the youngest woman: {youngestWomanAge}");
Console.WriteLine($"Average age of men: {averageMenAge:F1}");
