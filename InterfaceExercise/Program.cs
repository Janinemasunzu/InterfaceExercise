using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany Done

            //Create 3 classes called Car , Truck , & SUV Done

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car myCar = new Car();
            myCar.NumberOfWheels = 4;
            myCar.HasEngine = true;
            myCar.HasHeadLights = true;
            myCar.Year = 2023;
            myCar.Logo = string.Empty;
            myCar.Name = string.Empty;


            Suv mySuv = new Suv();
            mySuv.NumberOfWheels = 4;
            mySuv.HasEngine = true;
            mySuv.HasHeadLights = true;
            mySuv.Year = 2022;
            mySuv.Logo = string.Empty; 
            mySuv.Name = string.Empty;


            Truck myTruck = new Truck();
            myTruck.NumberOfWheels = 6;
            myTruck.HasEngine = true;
            myTruck.HasHeadLights = true;
            myTruck.Year = 2021;
            myTruck.Logo = string.Empty; 
            myTruck.Name = string.Empty;

            List<IVehicle> myVehicleList = new List<IVehicle>();
            myVehicleList.Add(myCar);
            myVehicleList.Add(mySuv);
            myVehicleList.Add(myTruck);

           

            foreach ( var vehicle in myVehicleList) 
            {
                Console.WriteLine($"Number of Wheels: {vehicle.NumberOfWheels}");
                Console.WriteLine($"Has Engine: {vehicle.HasEngine}");
                Console.WriteLine($"Has Headlights: {vehicle.HasHeadLights}");
                Console.WriteLine($"Was made in: {vehicle.Year}");
                Console.WriteLine($"Has a Logo: {vehicle.Logo}");
                Console.WriteLine($"It's name is: {vehicle.Name}");
               
                vehicle.HonkNoise();
                Console.WriteLine();
            }

        }
    }
}
