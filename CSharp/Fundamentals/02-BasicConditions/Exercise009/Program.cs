// Exercise009 - Triangle Formation Check Challenge
// Write a program that reads the lengths of three line segments
// and determines whether they can form a triangle. To form a triangle,
// the length of each side must be less than the sum of the other two sides.

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
  Console.WriteLine("The given segments can form a triangle.");
else
  Console.WriteLine("The given segments cannot form a triangle.");
