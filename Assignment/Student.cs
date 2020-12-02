using System;
namespace Assignment
{
    public class Student : Person
    {
        string studentNumber;
        int age;
        Address address;
        string fullName;
        int[] scores;
        double averageScores;
        string fullAddress;



        public Student(string St, int A, Address Ad, string First, string Last, int[] Sc, double Av) : base(First, Last)
        {
            this.studentNumber = St;
            this.age = A;
            this.address = Ad;
            this.fullName = First + " " + Last;
            this.scores = Sc;
            this.averageScores = Av;
            this.fullAddress = Ad.toString();
        }



        public string StudentNumber
        {
            get { return studentNumber; } set { studentNumber = value; }
        }
        public int Age
        {
            get { return age; } 
        }
        public Address Address
        {
            get { return Address; } set { Address = value; }
        }
        public string FullName
        {
            get { return fullName; } 
        }
        public int[] Scores
        {
            get { return scores; } set { scores = value; }
        }
        public double AverageScores
        {
            get { return averageScores; } set { averageScores = value; }
        }
        public string FullAddress
        {
            get { return fullAddress; } set { fullAddress = value; }
        }



        public string ToStringScore()
        {
            return "Student " + FullName + " score is " + AverageScores;
        }
        public string ToStringCity()
        {
            return "Student " + FullName + " is living in " + address.City;
        }
        public string ToStringAddress()
        {
            return "Student " + FullName + " address is " + FullAddress;
        }
        public string ToStringAge()
        {
            return "Student " + FullName + " is " + Age + " years old";
        }
        public string ToStringStudentNumber()
        {
            return "Student " + FullName + " number is " + StudentNumber;
        }
    }
}
