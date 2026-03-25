// Exercise003 - Average Age with Sentinel Value
// Write a program that reads the ages of multiple students
// and stops when the value 999 is entered.
// At the end, display the total number of students
// and the average age of the group.

Console.WriteLine("Enter the age of the students.");
Console.WriteLine("Type 999 to finish input.\n");

int totalAge = 0;
int totalStudents = 0;
const int SentinelValue = 999;

while (true)
{
  Console.Write("Enter a student's age: ");
  int age = Convert.ToInt32(Console.ReadLine());

  if (age == SentinelValue)
  {
    Console.WriteLine("Sentinel value (999) detected. Ending input...\n");
    break;
  }

  totalAge += age;
  totalStudents++;
  Console.WriteLine("\n--------------------\n");
}

double averageAge = totalStudents > 0 ? (double)totalAge / totalStudents : 0;

Console.WriteLine($"Total number of students: {totalStudents}");
Console.WriteLine($"Average age: {averageAge:F1}");
