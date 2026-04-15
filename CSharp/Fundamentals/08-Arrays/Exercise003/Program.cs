// Exercise003 - Initialize Array with Descending Sequence
// Write a program that creates an array with 10 positions
// and fills it using a logical pattern, generating values
// from 9 down to 0.

int[] numbers = new int[10];

for (int index = 0; index < numbers.Length; index++)
  numbers[index] = 9 - index;
