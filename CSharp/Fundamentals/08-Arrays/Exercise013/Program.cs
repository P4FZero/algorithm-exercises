// Exercise013 - Sort Random Array (Challenge)
// Write a program that fills an array with 20 random numbers
// between 0 and 99, displays the generated values,
// then sorts the array in ascending order and displays the sorted result.

Console.Clear();
Console.Title = "Sort Random Array";
Console.WriteLine("=== Sort Random Array ===\n");

WriteColored("Generating 20 random numbers between 0 and 99...\n", ConsoleColor.Blue);

int[] numbers = new int[20];
FillArrayRandomly(numbers);

WriteColored("Generated values:", ConsoleColor.Green);
DisplayArrayValues(numbers);

Console.WriteLine();
WriteColored("\nSorting the values in ascending order...\n", ConsoleColor.Blue);

SortArray(numbers);

WriteColored("Sorted values:", ConsoleColor.Cyan);
DisplayArrayValues(numbers);

static void DisplayArrayValues(int[] array)
{
  foreach (var item in array)
  {
    Console.Write($"{item,2} ");
  }
}

static void FillArrayRandomly(int[] array)
{
  Random random = new Random();
  const int MinValue = 0;
  const int MaxValue = 99;

  for (int index = 0; index < array.Length; index++)
  {
    array[index] = random.Next(MinValue, MaxValue + 1);
  }
}

// Alternative .Sort()
static void SortArray(int[] array)
{
  for (int outerIndex = 0; outerIndex < array.Length - 1; outerIndex++)
  {
    for (int innerIndex = outerIndex + 1; innerIndex < array.Length; innerIndex++)
    {
      if (array[outerIndex] > array[innerIndex])
      {
        (array[innerIndex], array[outerIndex]) = (array[outerIndex], array[innerIndex]);
      }
    }
  }
}

static void WriteColored(string message, ConsoleColor color)
{
  Console.ForegroundColor = color;
  Console.WriteLine(message);
  Console.ResetColor();
}
