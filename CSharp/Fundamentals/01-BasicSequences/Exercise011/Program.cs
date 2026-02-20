// Exercise011 - Quadratic Equation Delta
// Write a program that reads the coefficients A, B, and C of a quadratic
// equation and calculates the value of the discriminant (Delta).

Console.Write("Value of A: ");
double valueA = Convert.ToDouble(Console.ReadLine());

Console.Write("Value of B: ");
double valueB = Convert.ToDouble(Console.ReadLine());

Console.Write("Value of C: ");
double valueC = Convert.ToDouble(Console.ReadLine());

double delta = Math.Pow(valueB, 2) - 4 * valueA * valueC;

Console.WriteLine($"The Delta value is: {delta}");
