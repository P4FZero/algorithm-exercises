// Exercise002 - Initialize Array with Arithmetic Sequence
// Write a program that creates an array with 10 positions
// and fills it using a logical pattern, generating values
// from 5 to 50 with a step of 5.

int[] numbers = new int[10];

for (int index = 0; index < numbers.Length; index++)
{
  numbers[index] = (index + 1) * 5;
}
