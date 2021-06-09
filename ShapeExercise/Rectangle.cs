using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeExercise
{
    class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle( int length, int width)
        {
            Length = length;
            Width = width;
        }

        public override void CalculateArea(int length, int width)
        {
            int area = length * width;
            Console.WriteLine($"The area of the rectangle is {area} square units.");
        }

        public override void CalculatePerimeter(int length, int width)
        {
            int perimeter = length * 2 + width * 2;
            Console.WriteLine($"The perimeter of the rectangle is {perimeter} units.");
        }
    }
}
