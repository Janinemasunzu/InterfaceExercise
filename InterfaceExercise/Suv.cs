using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Suv: IVehicle, ICompany
    {
        public int NumberOfSeats { get; set; }
        public bool HasFourWheels { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasHeadLights { get; set; }
        public int Year { get; set; }
        public bool HasEngine { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public void HonkNoise() 
        {
            Console.WriteLine("The SUV's honknoise goes Hoook Hoook");
        }
    }
}
