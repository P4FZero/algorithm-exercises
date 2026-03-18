// Exercise009 - Body Mass Index (BMI) Classification
// Write a program that reads a person's weight and height,
// calculates the Body Mass Index (BMI), and classifies
// the result according to predefined BMI ranges.

Console.Write("Enter your weight (in kilograms): ");
double personWeight = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter your height (in meters): ");
double personHeight = Convert.ToDouble(Console.ReadLine());

double bmi = personWeight / (personHeight * personHeight);
Console.WriteLine($"Your BMI is: {bmi:F1}");

string bmiClassification = bmi switch
{
  < 18.5 => "Underweight",
  >= 18.5 and < 25 => "Normal weight",
  >= 25 and < 30 => "Overweight",
  >= 30 and < 35 => "Obesity (Class I)",
  >= 35 and < 40 => "Obesity (Class II)",
  _ => "Obesity (Class III)"
};

Console.WriteLine($"Classification: {bmiClassification}");
