// Exercise010 - Wall Area and Paint Calculation
// Write a program that calculates the area of a wall based on
// its width and height and determines how many liters of paint
// are required, assuming 1 liter covers 2 square meters.

Console.Write("Wall height: ");
double wallHeight = Convert.ToDouble(Console.ReadLine());

Console.Write("Wall width: ");
double wallWidth = Convert.ToDouble(Console.ReadLine());

double squareMeters = wallHeight * wallWidth;
double totalPaint = squareMeters / 2;

Console.WriteLine($"Required paint: {totalPaint:F2} liters");
