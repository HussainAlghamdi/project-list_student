using System;
using System.Collections.Generic;

namespace list_student
{
    public class Student
    {
        public string name;
        public int degree;
    }
    public class Program
    {
        //static int i = 5;

        static void Main(string[] args)
        {
            //int x = i;
            List<Student> students = new List<Student>();
            string option;

            do
            {
                Console.WriteLine("Student name :");
                string name = Console.ReadLine();
                Console.WriteLine("Student Grade :");
                int degree = Convert.ToInt32( Console.ReadLine());
                Student s = new Student();
                s.name = name;
                s.degree = degree;
                students.Add(s);

                Console.WriteLine("Add Another Student ? (Yes/No)");
                option = Console.ReadLine();

                while (option.ToLower() != "yes" && option.ToLower() !="no")
                {
                    Console.WriteLine("Invalid Input\nPlesse Enter Yes Or No");
                    option = Console.ReadLine();

                }

            } while (option.ToLower() == "yes");

            foreach (var item in students)
            {
                Console.WriteLine($"Student name : {item.name} , Student Grade : {item.degree}");
            }
            Console.WriteLine("Enter the Grade to search :");
            int degree1 = Convert.ToInt32(Console.ReadLine());
            Check(students, degree1);
            


        }

        public static void Check(List<Student> s, int grade)
        {
            int count = 0;
            foreach (var item in s)
            {
                if (item.degree == grade)
                {
                    count++;
                }
                
            }

            Console.WriteLine($"number of Student with grade {grade} is : {count}");
        }
    }
}
