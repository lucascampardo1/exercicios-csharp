using System;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            int WorkingHours = int.Parse(Console.ReadLine());
            int Days = int.Parse(Console.ReadLine());
            double HourlyRate = double.Parse(Console.ReadLine());
            double Salary = WorkingHours * HourlyRate * Days;
            Console.WriteLine("\nNAME: " + name);
            Console.WriteLine("SALARY: " + Salary.ToString("F2"));
        }
    }
}