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

        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine()?.Trim() ?? "";

        int id = ReadEmployeeId();

        Console.Write("Enter photo URL: ");
        string photoUrl = Console.ReadLine()?.Trim() ?? "";

        employees.Add(new Employee(firstName, lastName, id, photoUrl));
      }

      return employees;
    }

    static int ReadEmployeeId()
    {
      while (true)
      {
        Console.Write("Enter ID: ");
        if (Int32.TryParse(Console.ReadLine(), out int id))
        {
          return id;
        }

        Console.WriteLine("Please enter a valid whole-number ID.");
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
