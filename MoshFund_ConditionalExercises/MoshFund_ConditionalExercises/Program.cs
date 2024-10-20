using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MoshFund_ConditionalExercises
{

    public class Program
    {
        static void Main(string[] args)
        {
            ValidNumber number = new ValidNumber();
            number.EnterNumber();
            number.DisplayNumber();

            var maxNumber = new MaximumNumber();
            maxNumber.InputNumber();
            maxNumber.OutputNumber();

            ImageOrientation imageOrientation = new ImageOrientation();
            imageOrientation.Input();
            Console.WriteLine(imageOrientation.PortraitImage());

            SpeedLimit speedLimit = new SpeedLimit();
            speedLimit.GetSpeedLimit();
            speedLimit.GetCarSpeed();
            speedLimit.ValidSpeedLimit();

            SpeedInput input = new SpeedInput();
            SpeedMonitor monitor = new SpeedMonitor();

            int validSpeedLimit = input.GetSpeedLimit();
            int carSpeed = input.GetCarSpeed();

            monitor.ValidSpeedLimit(validSpeedLimit, carSpeed);
        }
    }
}
