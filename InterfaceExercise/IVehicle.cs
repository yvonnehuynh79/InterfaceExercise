using System;
namespace InterfaceExercise
{
	interface IVehicle
	{
		public int WheelsCount { get; set; }
        public int Year { get; set; }
		public string Make { get; set; }
		public int NumberOfDoors { get; set; }

		public void HonkNoise();


        
	}
}

