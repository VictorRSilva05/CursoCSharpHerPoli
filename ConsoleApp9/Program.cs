using ConsoleApp9.Entities;
using System.Net.Http.Headers;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            byte n = byte.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nEmployee #{i + 1} data:");
                Console.Write("Outsourced (y/n)?  ");
                string outsourced = Console.ReadLine().ToLower();

                bool outsider = false;
                if (outsourced == "y")
                {
                    outsider = true;
                }
                else if (outsourced == "n")
                {
                    outsider = false;
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (outsider == true)
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
