// Exercise006 - Arithmetic Progression (AP) Generator (Challenge)
// Write a program that reads the first term and the common difference
// of an arithmetic progression, displays the first 10 terms,
// and calculates the sum of the sequence.

Console.WriteLine("=== Arithmetic Progression (AP) Generator ===\n");

Console.Write("Enter the first term of the progression: ");
int firstTerm = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter de common difference: ");
int commonDifference = Convert.ToInt32(Console.ReadLine());

const int NumberOfTerms = 10;

int currentTerm = firstTerm;

for (int termCount = 0; termCount < NumberOfTerms; termCount++)
{
  Console.WriteLine(currentTerm);
  currentTerm += commonDifference;
}

int lastTerm = firstTerm + (NumberOfTerms - 1) * commonDifference;
int sequenceTotal = NumberOfTerms * (firstTerm + lastTerm) / 2;

Console.WriteLine($"Sum of the first 10 terms: {sequenceTotal}");
