using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public SUV()
        {

        }
        public SUV(bool hasCargoSpace, bool hasComfortableSeats, int wheelsCount)
        {
            HasCargoSpace = hasCargoSpace;
            HasComfortableSeats= hasComfortableSeats;
            WheelsCount = wheelsCount;
        }

        public bool HasCargoSpace { get; set; }
        public bool HasComfortableSeats { get; set; }

        public int WheelsCount { get; set; } = 4;
        public int Year { get; set; } = 2023;
        public string Make { get; set; }
        public int NumberOfDoors { get; set; } = 4;

        public int HasEmpployees { get; set; }
        public string CompanyName { get; set; }


        public void HonkNoise()
        {
            Console.WriteLine("The noise is not too bad for this SUV");
        }


        
        
	}
}

