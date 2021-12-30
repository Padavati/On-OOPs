using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent_Teacher
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

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greet();
            teacher.Explain();

            Console.ReadKey();
        }
    }
    public class Person
    {
        protected int age;
        public void SetAge(int n)
        {
            age = n;
        }
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
    }
    public class Student:Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is :{0} years old", age);
        }
    }
    public class Teacher:Person
    {
        private string Subject;
        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }

    }
}
