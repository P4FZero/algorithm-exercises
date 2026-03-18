// Exercise003 - Land Area Classification
// Write a program that reads the width and length of a rectangular land plot,
// calculates its area in square meters, and classifies it as Popular
// (below 100 m²), Master (between 100 m² and 500 m²), or VIP (above 500 m²).

Console.Write("Enter the width of the land plot (in meters): ");
double landWidth = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the length of the land plot (in meters): ");
double landLength = Convert.ToDouble(Console.ReadLine());

double landArea = landWidth * landLength;
Console.WriteLine($"The total area of the land plot is: {landArea:F1} square meters (m²).");

string landClassification = landArea switch
{
  < 100 => "Popular",
  <= 500 => "Master",
  _ => "VIP"
};

Console.WriteLine($"Classification: {landClassification}");
