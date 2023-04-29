using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		
        public bool HasFlatBed { get; set; }
        public int HasWheels { get; set; } = 4;

        public int WheelsCount { get; set; } = 4;
        public int Year { get; set; } = 2015;
        public string Make { get; set; }
        public int NumberOfDoors { get; set; } = 4;

        public int HasEmpployees { get; set; }
        public string CompanyName { get; set; }



        public void HonkNoise()
        {
            Console.WriteLine("This truck has a loud noise");
        }
       


        


        
    }
}

