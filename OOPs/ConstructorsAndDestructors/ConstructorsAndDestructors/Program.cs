using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndDestructors
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Person[] person = new Person[3];
            for(int i=0;i<3;i++)
            {
                person[i] = new Person( Console.ReadLine());
            }
            for(int i=0;i<3;i++)
            {
                Console.WriteLine(person[i].ToString());

            }
            Console.ReadKey(); 

        }
    }
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)   //Constructor
        {
            Name = name;
        }
        public override string ToString()
        {
            return "Hello! My Name is" +  Name;
        }
        ~Person()  //Destructor
        {
            Name = string.Empty;
        }

    }
}