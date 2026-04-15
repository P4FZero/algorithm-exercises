// Exercise004 - Initialize Array with Alternating Values
// Write a program that creates an array with 10 positions
// and fills it using a logical pattern, alternating
// between the values 5 and 3.

int[] numbers = new int[10];

for (int index = 0; index < numbers.Length; index++)
  numbers[index] = index % 2 == 0 ? 5 : 3;
