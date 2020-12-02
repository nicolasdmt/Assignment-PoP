using System;
namespace Assignment
{
    public class Person
    {
        string firstName;
        string lastName;



        public Person(string First, string Last)
        {
            if (First != null && Last != null)
            {
                this.firstName = First;
                this.lastName = Last;
            }
            else { Console.WriteLine("Impossible to create a person"); }
        }



        public string FirstName
        {
            get { return firstName; } 
        }
        public string LastName
        {
            get { return lastName; }
        }
    }
}
