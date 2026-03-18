// Exercise005 - Triangle Type Classification Challenge
// Based on the triangle validation exercise from BasicConditions,
// write a program that reads the lengths of three line segments,
// determines whether they can form a triangle, and if so,
// classifies it as Equilateral, Isosceles, or Scalene.

Console.Write("Enter the length of the first segment: ");
int sideA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the length of the second segment: ");
int sideB = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the length of the third segment: ");
int sideC = Convert.ToInt32(Console.ReadLine());

bool isTriangle =
  sideA + sideB > sideC &&
  sideA + sideC > sideB &&
  sideB + sideC > sideA;

if (isTriangle)
{
  Console.WriteLine("The given segments can form a triangle.");

  string triangleClassification;

  if (sideA == sideB && sideA == sideC)
    triangleClassification = "Equilateral";
  else if (sideA == sideB || sideA == sideC || sideB == sideC)
    triangleClassification = "Isosceles";
  else
    triangleClassification = "Scalene";

  Console.WriteLine($"Classification: {triangleClassification}");
}
else
  Console.WriteLine("The given segments cannot form a triangle.");
