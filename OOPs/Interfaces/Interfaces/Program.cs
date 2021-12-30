using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);

            int Fuel = int.Parse(Console.ReadLine());
            if(car.Refuel(Fuel))
            {
                car.Drive();
            }
            Console.ReadKey();
        }
    }
    interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }
    public class Car:IVehiculo
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            this.Fuel = fuel;
        }
        public void Drive()
        {
            if(Fuel>0)
            {
                Console.WriteLine("Driving");
            }
            else 
            {
                Console.WriteLine("Not Fuel");
            }
        }
        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
    }
}
