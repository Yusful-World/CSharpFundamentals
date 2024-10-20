using System;

namespace MoshInt_MethodOverride
{
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }
    }
}
