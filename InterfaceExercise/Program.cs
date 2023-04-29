using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Done Create 2 Interfaces called IVehicle & ICompany

            //Done Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Done Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /* Done Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Done Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car car= new Car();
            car.Year = 2001;
            car.Make = "Honda";
            car.WheelsCount = 4;
            car.HasTrunk = true;

            SUV suv = new SUV(true, true, 4);


            Truck truck = new Truck()
            {
                HasEmpployees = 405,
                HasFlatBed = true,
                CompanyName = "The Big Company"
            };

            List<IVehicle> listOfVehicles = new List<IVehicle>();
            listOfVehicles.Add(car);
            listOfVehicles.Add(suv);
            listOfVehicles.Add(truck);


            
            foreach (var item in listOfVehicles)
            {
                Console.WriteLine("Car informations");
                item.HonkNoise();
                Console.WriteLine($"This car has {item.WheelsCount} wheels");
                Console.WriteLine($"This car has {item.NumberOfDoors}doors");
                Console.WriteLine($"{item.Year}");
                
                


            }
        }
    }
}
