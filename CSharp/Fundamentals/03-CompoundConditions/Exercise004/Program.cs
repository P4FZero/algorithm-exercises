// Exercise004 - Salary Adjustment by Years of Service
// Write a program that reads an employee's name, current salary,
// and years of service, then calculates the new salary based on
// the following rules: 3% increase for up to 3 years,
// 12.5% between 3 and 10 years, and 20% for 10 years or more.

Console.Write("Enter the employee's name: ");
string employeeName = Console.ReadLine();

Console.Write("Enter the current salary: ");
decimal currentSalary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter the number of years of service: ");
int yearsOfService = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine($"Employee name: {employeeName}");
Console.WriteLine($"Current salary: {currentSalary:C}");
Console.WriteLine($"Years of service: {yearsOfService}\n");

decimal increaseRate = yearsOfService switch
{
  <= 3 => 0.03M,
  > 3 and < 10 => 0.125M,
  _ => 0.20M
};

decimal newSalary = currentSalary * (1 + increaseRate);

Console.WriteLine($"A {increaseRate:P1} salary increase has been applied.");
Console.WriteLine($"New salary: {newSalary:C}");
