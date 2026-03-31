// Exercise005 - Weight and Gender Statistics with For Loop
// Write a program that reads the gender and weight of 8 people,
// then counts how many women were registered, how many men weigh
// over 100kg, calculates the average weight of women,
// and determines the highest weight among men.

Console.WriteLine("Please enter the gender and weight of 8 people.");

const int NumberOfPeople = 8;
int totalWomen = 0;
int menOverHundred = 0;
double totalWomenWeight = 0;
double highestMenWeight = double.MinValue;

for (int count = 0; count < NumberOfPeople; count++)
{
  Console.Write($"Enter the gender of person #{count + 1} (M/F): ");
  char personGender = Console.ReadLine().ToUpper()[0];

  Console.Write($"Enter the weight of person #{count + 1} (in kg): ");
  double personWeight = Convert.ToDouble(Console.ReadLine());

  if (personGender == 'F')
  {
    totalWomen++;
    totalWomenWeight += personWeight;
  }
  else
  {
    if (personWeight > 100)
      menOverHundred++;

    highestMenWeight = Math.Max(highestMenWeight, personWeight);
  }

  Console.WriteLine("\n--------------------\n");
}

Console.WriteLine($"There are {totalWomen} women in the group.");
Console.WriteLine($"There are {menOverHundred} men over 100kg.");

if (totalWomen > 0)
  Console.WriteLine($"The average weight of women: {totalWomenWeight / totalWomen:F1} kg.");
else
  Console.WriteLine("No women were entered.");

if (highestMenWeight != double.MinValue)
  Console.WriteLine($"Highest weight among men: {highestMenWeight} kg.");
else
  Console.WriteLine("No men were entered.");
