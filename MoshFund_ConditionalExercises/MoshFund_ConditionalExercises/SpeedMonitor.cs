using System;

namespace MoshFund_ConditionalExercises
{
    public class SpeedMonitor
    {
        public void ValidSpeedLimit(int speedLimit, int carSpeed)
        {
            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else if (carSpeed == speedLimit)
            {
                Console.WriteLine("Caution! Watch your speed");
            }
            else
            {
                int demeritPoints = DemeritPoints(carSpeed, speedLimit);
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                Console.WriteLine("Demerit Points: " + demeritPoints);

            }

        }

        public int DemeritPoints(int carSpeed, int speedLimit)
        {
            const int kmPerDemeritPoint = 5;
            
            return (carSpeed - speedLimit) / kmPerDemeritPoint;
        }
    }
}
