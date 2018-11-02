using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDrone_JayStiles
{
    class Drone
    {
        private double totalDistance;
        private double totalFlyTime;


        public Drone(double totalDistance, double totalFlyTime)
        {
            this.totalDistance = totalDistance;
            this.totalFlyTime = totalFlyTime;

            double calculatedSpeed = totalDistance / totalFlyTime;
            Console.WriteLine($"Drone went {calculatedSpeed} feet per second.");
            return;
        }


    }
}
