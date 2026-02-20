// Exercise008 - Distance Unit Conversion
// Write a program that reads a distance in meters
// and displays the equivalent values in other metric units.

Console.Write("Enter a distance in meters: ");
double meters = Convert.ToDouble(Console.ReadLine());

double decameters = meters / 10;
double hectometers = meters / 100;
double kilometers = meters / 1000;
double decimeters = meters * 10;
double centimeters = meters * 100;
double millimeters = meters * 1000;

Console.WriteLine($"The distance of {meters} m corresponds to:");
Console.WriteLine($"{kilometers:F5} km");
Console.WriteLine($"{hectometers:F4} hm");
Console.WriteLine($"{decameters:F3} dam");
Console.WriteLine($"{decimeters:F1} dm");
Console.WriteLine($"{centimeters:F1} cm");
Console.WriteLine($"{millimeters:F1} mm");
