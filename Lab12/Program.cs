using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student("Adam White", "48539 Tilch  Macomb, MI 48044", "C# OOP", 2019, 1000000);
            Console.WriteLine($" {newStudent.ToString()} ");

            Staff newStaff = new Staff("Adam White", "48539 Tilch  Macomb, MI 48044", "Grand Circus", 40000.00);
            Console.WriteLine($" {newStaff.ToString()} ");

            Person newPerson = new Person("Adam White", "48539 Tilch  Macomb, MI 48044");
            Console.WriteLine($" {newPerson.ToString()} ");

        }
    }
}
