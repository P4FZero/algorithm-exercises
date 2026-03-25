// Exercise016 - Weight and Height Statistics
// Write a program that reads the weight and height of 7 people,
// then calculates the average height, counts how many weigh over 90kg,
// how many weigh less than 50kg and are shorter than 1.60m,
// and how many are taller than 1.90m and weigh more than 100kg.

int count = 0;
double totalGroupHeight = 0;
int totalWeightOverNinety = 0;
int totalWeightUnderFifty = 0;
int totalWeightOverHundred = 0;

while (count < 7)
{
  Console.Write($"Enter the weight of person #{count + 1} (in kg): ");
  double personWeight = Convert.ToDouble(Console.ReadLine());

  Console.Write($"Enter the height of person #{count + 1} (in meters): ");
  double personHeight = Convert.ToDouble(Console.ReadLine());

  totalGroupHeight += personHeight;

  if (personWeight > 90)
    totalWeightOverNinety++;

  if (personWeight < 50 && personHeight < 1.60)
    totalWeightUnderFifty++;

  if (personWeight > 100 && personHeight > 1.90)
    totalWeightOverHundred++;

  Console.WriteLine("\n--------------------\n");

  count++;
}

double averageGroupHeight = totalGroupHeight / count;

Console.WriteLine($"Average height: {averageGroupHeight:F2} meters");
Console.WriteLine($"Number of people weighing over 90 kg: {totalWeightOverNinety}");
Console.WriteLine($"Number of people weighing less than 50 kg and shorter than 1.60 m: {totalWeightUnderFifty}");
Console.WriteLine($"Number of people weighing more than 100 kg and taller than 1.90 m: {totalWeightOverHundred}");
