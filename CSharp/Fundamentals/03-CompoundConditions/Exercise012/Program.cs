// Exercise012 - Salary Adjustment by Gender and Years of Service
// Write a program that reads the current salary, the employee's gender,
// and years of service, then calculates the new salary based on
// different increase rates for men and women according to defined ranges.

Console.Write("Enter the current salary: ");
decimal currentSalary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Enter the employee's gender (M/F): ");
char employeeGender = Convert.ToChar(Console.ReadLine().ToUpper()[0]);

Console.Write("Enter the number of years of service: ");
int yearsOfService = Convert.ToInt32(Console.ReadLine());

decimal increaseRate;

if (employeeGender == 'M')
{
  increaseRate = yearsOfService switch
  {
    < 20 => 0.03M,
    <= 30 => 0.13M,
    _ => 0.25M
  };
}
else if (employeeGender == 'F')
{
  increaseRate = yearsOfService switch
  {
    < 15 => 0.05M,
    <= 20 => 0.12M,
    _ => 0.23M
  };
}
else
{
  Console.WriteLine("Invalid gender input");
  return;
}

Console.Clear();
Console.WriteLine("Calculating the new salary based on gender and years of service...\n");

decimal newSalary = currentSalary + (currentSalary * increaseRate);

Console.WriteLine($"Current salary: {currentSalary:C}");
Console.WriteLine($"Gender: {(employeeGender == 'M' ? "Male" : "Female")}");
Console.WriteLine($"Years of service: {yearsOfService}");
Console.WriteLine($"Increase rate applied: {increaseRate:P0}");
Console.WriteLine($"New salary: {newSalary:C}");
