// Exercise007 - Fibonacci Sequence (Challenge)
// Write a program that displays the first 10 terms
// of the Fibonacci sequence using a for loop.

const int NumberOfTerms = 10;

int termA = 0;
int termB = 1;

for (int termCount = 0; termCount < NumberOfTerms; termCount++)
{
  Console.WriteLine(termB);

  int termC = termA + termB;
  termA = termB;
  termB = termC;
}
