using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDrone_JayStiles
{
    class Program
    {
        public double callFlightSpeed { get; private set; }
        

        static void Main(string[] args)
        {

            Console.Write("Enter flight time in seconds: ");
            double totalFlyTime = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter flight distance in feet: ");
            double totalDistance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter flight time in seconds for the quad: ");
            double totalFlyTime1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter flight distance in feetfor the quad: ");
            double totalDistance1 = Convert.ToDouble(Console.ReadLine());

            Drone drone = new Drone(totalDistance, totalFlyTime);
            QuadRotorDrone quadRotor = new QuadRotorDrone(totalDistance1, totalFlyTime1);

        }

    }

}