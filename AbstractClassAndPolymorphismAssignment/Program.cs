using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndPolymorphismAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class and set the properties
            Employee employee = new Employee() { Id = 1, FirsName = "Sample", LastName = "Student" };
            // Call the SayName method to display the employee's full name
            employee.SayName();
            // Keep the console window open
            Console.ReadLine();
        }
    }
}
