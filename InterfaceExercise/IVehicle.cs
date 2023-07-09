using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle: ICompany
    {
        public int NumberOfWheels { get; set; } 
        public bool HasHeadLights { get; set; }
        public int Year { get; set; }
        public bool HasEngine { get; set; }

        public void HonkNoise();

        
    }
}
