using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeExercise
{
    class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle(int Radius)
        {
            this.Radius = Radius;

        }

        public override double CalculateArea()
        {
            Console.WriteLine(Math.PI * Radius * Radius);
            int area = (int)(Math.PI * Radius * Radius);

            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * Radius;
            return perimeter;
        }

        public override void PrintInfo()
        {
            Console.WriteLine("This is a circle");
            Console.WriteLine("The length of the four sides is: " + Radius);
        }
    }
}
