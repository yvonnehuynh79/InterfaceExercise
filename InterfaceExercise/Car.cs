using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
	
		
	
        public bool HasTrunk { get; set; }
        public int HasDoors { get; set; }

        public int WheelsCount { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public int NumberOfDoors { get; set; } = 4;

        public int HasEmpployees { get; set; }
        public string CompanyName { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("This car has a quiet noise");
        }

        /*public void PrintVehicleDetails()
        {
            Console.WriteLine($"This car has {NumberOfDoors}doors");
            Console.WriteLine($"The Big Company is the name{CompanyName}");
        }*/

        




        

	}
}

