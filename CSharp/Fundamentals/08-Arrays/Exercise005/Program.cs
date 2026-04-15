// Exercise005 - Fibonacci Sequence in Array
// Write a program that creates an array and fills it with
// the first Fibonacci sequence values using logical calculation.

int[] fibonacci = new int[15];

int termA = 0;
int termB = 1;

for (int index = 0; index < fibonacci.Length; index++)
{
  fibonacci[index] = termB;

  int termC = termA + termB;
  termA = termB;
  termB = termC;
}
