using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        private int CarSpeed = 0;

        public void PrintSpeed()
        {
            if (CarSpeed == 0) Console.WriteLine("Stop");
            else if (CarSpeed > 1) Console.WriteLine("Driving Forward");
            else Console.WriteLine("Driving backward");
        }

        public int DrivingForward()
        {
            return CarSpeed = 90;
        }
        public int DrivingBackward()
        {
            return CarSpeed = -10;
        }
        public int Stop()
        {
            return CarSpeed = 0;
        }
    }
}
