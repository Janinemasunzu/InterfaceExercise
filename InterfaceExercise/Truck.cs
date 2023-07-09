using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool HasBedSize { get; set; }
        public bool HasTrailer { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasHeadLights { get; set; }
        public int Year { get; set; }
        public bool HasEngine { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("The Truck's honk noise says vrooooom");
        }
    }

}
