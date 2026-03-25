// Exercise002 - Salary Sum by Gender with User Control
// Write a program that reads the salary and gender of multiple employees,
// accumulating the total salary for men and women separately.
// The program should continue based on user confirmation after each entry.

decimal totalMenSalary = 0;
decimal totalWomenSalary = 0;

while (true)
{
  Console.Write("Enter the employee's salary: ");
  decimal employeeSalary = Convert.ToDecimal(Console.ReadLine());

  Console.Write("Enter the employee's gender (M/F): ");
  char employeeGender = Console.ReadLine().ToUpper()[0];

  if (employeeGender == 'M')
    totalMenSalary += employeeSalary;
  else
    totalWomenSalary += employeeSalary;

  Console.Write("Do you want to enter another employee? (Y/N): ");
  char newEntry = Console.ReadLine().ToUpper()[0];

  Console.WriteLine("\n--------------------\n");
  
  if (newEntry == 'N')
  {
    Console.WriteLine("Updating salary totals...");
    break;
  }
}

Console.WriteLine($"Total salary from men: {totalMenSalary:C}");
Console.WriteLine($"Total salary from women: {totalWomenSalary:C}");
