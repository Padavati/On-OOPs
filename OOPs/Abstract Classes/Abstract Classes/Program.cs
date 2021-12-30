using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.SetName(Console.ReadLine());
            Console.WriteLine(dog.GetName());
            dog.Eat();

            Console.ReadKey();
           
        }
    }
    public abstract class Animal
    {
        private string Name { get; set; }

        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();
    }
    public class Dog:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
}
