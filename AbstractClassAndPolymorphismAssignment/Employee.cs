using System;

namespace AbstractClassAndPolymorphismAssignment
{
    // Create a class called Employee that inherits from the Person class and implements the SayName method.
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        // Implement the SayName method to display the employee's full name.
        public override void SayName()
        {
            Console.WriteLine($"Name: {FirsName} {LastName}");
        }

        // Implement the Quit method from the IQuittable interface to display a message indicating that the employee has quit the job.
        public void Quit()
        {
            Console.WriteLine($"{FirsName} {LastName} has quit the job.");
        }
    }
}
