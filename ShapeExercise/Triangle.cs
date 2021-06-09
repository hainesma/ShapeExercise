using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeExercise
{
    class Triangle : Shape
    {
        public int length { get; set; }
        public int width { get; set; }

        public int Length { get; set; }
        public int Width { get; set; }

        public Triangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public override void CalculateArea(int length, int width)
        {
            int area = (length * width) / 2;
            Console.WriteLine($"The area of the square is {area} square units.");
        }

        public override void CalculatePerimeter(int length, int width)
        {
            int perimeter = length1 + length2 + length3 ;
            Console.WriteLine($"The perimeter of the square is {perimeter} units.");
        }
    }
}
