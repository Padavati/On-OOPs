using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_of_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3];
            for(int i=0;i<3;i++)
            {
                if(i==0)
                {
                    person[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    person[i] = new Student(Console.ReadLine());
                }
            }

            for(int i=0;i<3;i++)
            {
                if(i==0)
                {
                    ((Teacher)person[i]).Explain();
                }
                else
                {
                    ((Student)person[i]).Study();
                }
            }

            Console.ReadKey();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    public class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("study");
        }
        public Student(string name):base(name)
        {
            Name = name;
        }
            
    }
   public class Teacher:Person
    {
        public void Explain()
        {
            Console.WriteLine("Explain");
        }
        public Teacher(string name):base(name)
        {
            Name = name;
        }
    }
}
