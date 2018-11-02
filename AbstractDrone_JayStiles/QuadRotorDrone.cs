using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDrone_JayStiles
{
    class QuadRotorDrone : Program
    {
        private double totalDistance1;
        private double totalFlyTime1;

        public QuadRotorDrone(double totalDistance, double totalFlyTime)
        {
            this.totalDistance1 = totalDistance;
            this.totalFlyTime1 = totalFlyTime;
        }

        private override void QuadDrone (double totalDistance1, double totalFlyTime1)
        {
            double calculatedSpeed = totalDistance1 / totalFlyTime1;
            Console.WriteLine($"Quad drone went {calculatedSpeed} feet per second.");
            return;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
