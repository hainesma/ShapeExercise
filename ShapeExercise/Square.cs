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

        public override int CalculateArea()
        {
            
            int area = Length * Length;
            return area;
        }

        public override int CalculatePerimeter()
        {
            int perimeter = Length * 4;
            return perimeter;
        }
    }
}
