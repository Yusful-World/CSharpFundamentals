using System;

namespace MoshFund_ConditionalExercises
{
    public class SpeedLimit
    {
        //Write a program that asks the user to enter the speed limit. Once set,
        //the program asks for the speed of a car. If the user enters a value less than the speed limit,
        //program should display Ok on the console. If the value is above the speed limit,
        //the program should calculate the number of demerit points. For every 5km/hr above the speed limit,
        //1 demerit points should be incurred and displayed on the console.
        //If the number of demerit points is above 12, the program should display License Suspended.
        private int speedLimit;
        private int demeritPoints;
        private int carSpeed;

        public void GetSpeedLimit()
        {
            Console.WriteLine("Enter speed limit: ");
            while (!int.TryParse(Console.ReadLine(), out speedLimit) || speedLimit < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid SpeedLimit: ");
            }
        }

        public void GetCarSpeed()
        {
            Console.WriteLine("Enter CarSpeed: ");
            while (!int.TryParse(Console.ReadLine(), out carSpeed) || carSpeed < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid speed: ");
            }
        }

        public int DemeritPoints()
        {
            const int kmPerDemeritPoint = 5;
            demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
            return demeritPoints;
        }

        public void ValidSpeedLimit()
        {
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if (carSpeed == speedLimit)
            {
                Console.WriteLine("Caution! Watch your speed");
            }
            else if (DemeritPoints() > 12)
            {
                Console.WriteLine("License Suspended");
            }
            Console.WriteLine("Demerit Points: " + demeritPoints); 
        }
    }
}
