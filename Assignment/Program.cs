using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, you are going to create a student in order to access to his/her information.\n"
                + "\n"
                + "First of all we need his/her name,\n"
                + "begin by writing his/her first name then press enter and add his/her last name.");
            string First = Convert.ToString(Console.ReadLine());
            string Last = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            Person person1 = new Person(First, Last);


            Console.WriteLine("Great ! Now, we need his/her address\n"
                + "\n"
                + "We'll proceed the same way, in this order :\n"
                + "- number of the street\n"
                + "- name of the street\n"
                + "- city\n"
                + "- country\n");
            int ANb = Convert.ToInt32(Console.ReadLine());
            string S = Convert.ToString(Console.ReadLine());
            string Ci = Convert.ToString(Console.ReadLine());
            string Co = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            Address address1 = new Address(ANb, S, Ci, Co);


            Console.WriteLine("Almost finished. Now his/her student number then his/her age");
            string St = Convert.ToString(Console.ReadLine());
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Finally his/her grade, how many grades does he/she have ?");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] Sc = new int[a];
            Console.WriteLine("You're gonna enter one by one each of his/her grade");
            for (int i = 0; i < Sc.Length; i++)
            {
                Sc[i] = Convert.ToInt32(Console.ReadLine());
            }
            double Av = 0;
            for (int i = 0; i < Sc.Length; i++)
            {
                Av += Sc[i];
            }
            Av /= a;
            Console.WriteLine("");
            Student student1 = new Student(St, A, address1, First, Last, Sc, Av);


            Console.WriteLine("Ok, the student is now created, here are some information about him/her");
            Console.WriteLine("");
            Console.WriteLine(student1.ToStringScore());
            Console.WriteLine(student1.ToStringCity());
            Console.WriteLine(student1.ToStringAddress());
            Console.WriteLine(student1.ToStringAge());
            Console.WriteLine(student1.ToStringStudentNumber());
        }
    }
}
