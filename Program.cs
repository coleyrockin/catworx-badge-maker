using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static List<Employee> GetEmployees()
    {
      List<Employee> employees = new List<Employee>();

      while (true)
      {
        Console.Write("Enter first name (leave empty to finish): ");
        string firstName = Console.ReadLine()?.Trim() ?? "";
        if (firstName == "")
        {
          break;
        }

        string lastName = ReadRequiredText("Enter last name: ");
        int id = ReadEmployeeId();
        string photoUrl = ReadRequiredText("Enter photo URL: ");

        employees.Add(new Employee(firstName, lastName, id, photoUrl));
      }

      return employees;
    }

    static string ReadRequiredText(string prompt)
    {
      while (true)
      {
        Console.Write(prompt);
        string value = Console.ReadLine()?.Trim() ?? "";
        if (value != "")
        {
          return value;
        }

        Console.WriteLine("This field is required.");
      }
    }

    static int ReadEmployeeId()
    {
      while (true)
      {
        Console.Write("Enter ID: ");
        if (Int32.TryParse(Console.ReadLine(), out int id) && id > 0)
        {
          return id;
        }

        Console.WriteLine("Please enter a positive whole-number ID.");
      }
    }

    static void Main(string[] args)
    {
      List<Employee> employees = GetEmployees();

      if (employees.Count == 0)
      {
        Console.WriteLine("No employees entered. Nothing to export.");
        return;
      }

      Util.PrintEmployees(employees);
      Util.MakeCSV(employees);
      Console.WriteLine("Badge data written to data/employees.csv");
    }
  }
}
