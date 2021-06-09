using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeExercise
{
    class Square : Shape
    {
        

        public Square(int length)
        {
            this.Length = Length;
        }

        public override double CalculateArea()
        {
            
            double area = Length * Length;
            return area;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = Length * 4;
            return perimeter;
        }
    }
}
