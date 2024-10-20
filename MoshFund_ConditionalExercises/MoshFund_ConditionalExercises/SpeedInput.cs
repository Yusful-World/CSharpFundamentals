using System;

namespace MoshFund_ConditionalExercises
{
    public class SpeedInput
    {
        private int speedLimit;
        private int carSpeed;

        public int GetSpeedLimit()
        {
            Console.WriteLine("Enter speed limit: ");
            while (!int.TryParse(Console.ReadLine(), out speedLimit) || speedLimit < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid SpeedLimit: ");
            }
            return speedLimit;
        }

        public int GetCarSpeed()
        {
            Console.WriteLine("Enter CarSpeed: ");
            while (!int.TryParse(Console.ReadLine(), out carSpeed) || carSpeed < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid speed: ");
            }
            return carSpeed;
        }
    }
}
