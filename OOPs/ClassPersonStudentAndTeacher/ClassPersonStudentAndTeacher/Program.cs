using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPersonStudentAndTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(21);
            student.Greet();
            student.ShowAge();
            student.Study();

            Teacher teacher = new Teacher();
            teacher.Greet();
            teacher.Explain();

            Console.ReadKey();
           
        }
    }
    public class Person
    {
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        protected int age;
        public void SetAge(int n)
        {
            age = n;
        }

    }
    public class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        } 
        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old", age);
        }

    }
    public class Teacher:Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }

    }
}
