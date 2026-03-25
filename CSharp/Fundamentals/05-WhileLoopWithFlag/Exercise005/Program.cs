// Exercise005 - People Data Analysis with Names
// Write a program that reads the name, age, and gender of multiple people,
// continuing based on user input. At the end, display the name of the
// oldest person, the name of the youngest woman, the average age of the group,
// how many men are over 30, and how many women are under 18.

string oldestPersonName = "";
int oldestPersonAge = int.MinValue;
string youngestWomanName = "";
int youngestWomanAge = int.MaxValue;
int totalAge = 0;
int totalPeople = 0;
int menOverThirty = 0;
int womenUnderEighteen = 0;

while (true)
{
  Console.Write("Enter the person's name: ");
  string personName = Console.ReadLine();

  Console.Write("Enter the person's age: ");
  int personAge = Convert.ToInt32(Console.ReadLine());

  Console.Write("Enter the person's gender (M/F): ");
  char personGender = Console.ReadLine().ToUpper()[0];

  if (personAge > oldestPersonAge)
  {
    oldestPersonAge = personAge;
    oldestPersonName = personName;
  }

  if (personGender == 'M')
  {
    if (personAge > 30)
    {
      menOverThirty++;
    }
  }
  else if (personGender == 'F')
  {
    if (personAge < youngestWomanAge)
    {
      youngestWomanAge = personAge;
      youngestWomanName = personName;
    }

    if (personAge < 18)
    {
      womenUnderEighteen++;
    }
  }

  totalAge += personAge;
  totalPeople++;

  Console.Write("Do you want to enter another person? (Y/N): ");
  char newEntry = Console.ReadLine().ToUpper()[0];

  if (newEntry == 'N')
  {
    Console.WriteLine("Updating statistics...\n");
    break;
  }

  Console.WriteLine("\n--------------------\n");
}

double averageAge = (double)totalAge / totalPeople;

Console.WriteLine($"Name of the oldest person: {oldestPersonName}");
Console.WriteLine($"Name of the youngest woman: {youngestWomanName}");
Console.WriteLine($"Average age of the group: {averageAge:F1}");
Console.WriteLine($"Number of men over 30 years old: {menOverThirty}");
Console.WriteLine($"Number of women under 18 years old: {womenUnderEighteen}");
