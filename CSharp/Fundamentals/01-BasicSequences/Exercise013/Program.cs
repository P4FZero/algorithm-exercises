// Exercise013 - Salary Increase Calculation
// Write a program that reads an employee's salary and calculates the new 
// salary after applying a 15% increase.

Console.Write("Employee's salary: ");
decimal employeeSalary = Convert.ToDecimal(Console.ReadLine());

decimal newEmployeeSalary = employeeSalary * 1.15M;

Console.WriteLine($"Employee's new salary: {newEmployeeSalary:C}");
