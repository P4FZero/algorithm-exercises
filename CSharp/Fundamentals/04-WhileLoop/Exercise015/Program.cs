// Exercise015 - Age and Gender Statistics
// Write a program that reads the age and gender of 5 people,
// then calculates the total number of men and women,
// the average age of the group, the average age of men,
// and how many women are over 20 years old.

int count = 0;
int totalMen = 0;
int totalWomen = 0;
double totalGroupAge = 0;
double totalMenAge = 0;
int womenOverTwenty = 0;

while (count < 5)
{
  Console.Write($"Enter the gender of person #{count + 1} (M/F): ");
  char personGender = Console.ReadLine().ToUpper()[0];

  Console.Write($"Enter the age of person #{count + 1}: ");
  int personAge = Convert.ToInt32(Console.ReadLine());

  if (personGender == 'M')
  {
    totalMen++;
    totalMenAge += personAge;
  }
  else
  {
    totalWomen++;

    if (personAge > 20)
      womenOverTwenty++;
  }

  totalGroupAge += personAge;

  Console.WriteLine("\n--------------------\n");

  count++;
}

double averageGroupAge = totalGroupAge / count;
double averageMenAge = totalMen > 0 ? totalMenAge / totalMen : 0;

Console.WriteLine($"Total number of men: {totalMen}");
Console.WriteLine($"Total number of women: {totalWomen}");
Console.WriteLine($"Average age of the group: {averageGroupAge:F1}");
Console.WriteLine($"Average age of men: {averageMenAge:F1}");
Console.WriteLine($"Number of women over 20 years old: {womenOverTwenty}");
