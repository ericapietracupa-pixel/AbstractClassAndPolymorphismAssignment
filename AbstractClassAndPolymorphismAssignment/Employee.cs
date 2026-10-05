using System;

namespace AbstractClassAndPolymorphismAssignment
{
    // Create a class called Employee that inherits from the Person class and implements the SayName method.
    public class Employee : Person
    {
        public int Id { get; set; }

        // Implement the SayName method to display the employee's full name.
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirsName} {LastName}");
        }
    }
}
