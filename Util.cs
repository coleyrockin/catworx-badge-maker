using System;
using System.Collections.Generic;
using System.IO;

namespace CatWorx.BadgeMaker
{
  class Util
  {
    public static void PrintEmployees(List<Employee> employees)
    {
      string template = "{0,-10}\t{1,-20}\t{2}";
      Console.WriteLine(String.Format(template, "ID", "Name", "Photo URL"));
      Console.WriteLine(new string('-', 60));

      foreach (Employee employee in employees)
      {
        Console.WriteLine(String.Format(template, employee.Id, employee.GetFullName(), employee.PhotoUrl));
      }
    }

    public static void MakeCSV(List<Employee> employees)
    {
      if (!Directory.Exists("data"))
      {
        Directory.CreateDirectory("data");
      }

      using (StreamWriter file = new StreamWriter("data/employees.csv"))
      {
        file.WriteLine("ID,Name,PhotoUrl");

        foreach (Employee employee in employees)
        {
          string template = "{0},{1},{2}";
          file.WriteLine(String.Format(template, employee.Id, EscapeCsv(employee.GetFullName()), EscapeCsv(employee.PhotoUrl)));
        }
      }
    }

    private static string EscapeCsv(string value)
    {
      if (value.Contains(',') || value.Contains('"') || value.Contains('\n'))
      {
        return $"\"{value.Replace("\"", "\"\"")}\"";
      }

      return value;
    }
  }
}
