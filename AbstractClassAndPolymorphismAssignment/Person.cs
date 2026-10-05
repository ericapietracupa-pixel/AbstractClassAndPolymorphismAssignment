namespace AbstractClassAndPolymorphismAssignment
{
    // Create an abstract class called Person with two properties: FirstName and LastName.
    public abstract class Person
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }

        // Create an abstract method called SayName
        public abstract void SayName();
    }
}
