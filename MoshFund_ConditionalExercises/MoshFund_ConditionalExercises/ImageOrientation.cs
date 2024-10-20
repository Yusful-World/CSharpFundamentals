using System;

namespace MoshFund_ConditionalExercises
{

    public class ImageOrientation
    {
        //3- Write a program and ask the user to enter the width and height of an image.
        //Then tell if the image is landscape or portrait.
        private int width;
        private int height;
        private string Portrait;
        private string Landscape;

        public void Input()
        {
            Console.WriteLine("Enter Width: ");
            while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater than zero for Width: ");
            }

            Console.WriteLine("Enter Height: ");
            while (!int.TryParse(Console.ReadLine(), out height) || height <= 0 )
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater thatn zero for Height: ");
            }

        }

        public string PortraitImage()
        {
            Portrait = "The image is Portrait";
            Landscape = "The image is Landscape";
            if (width > height)
            {
                return Landscape;
            }
            return Portrait;
        }

    }
}
