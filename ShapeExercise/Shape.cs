﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeExercise
{
    class Shape
    {
        //properties go here if any
        public int Length { get; set; }
        public int Width { get; set; }


        // We won't use a constructor here because we don't want to force parameters on the children

        public virtual int CalculateArea()
        {
            int area = Length * Width;
            return area;
        }

        public virtual int CalculatePerimeter() 
        {
            int perimeter = Length * 2 + Width * 2;
            return perimeter;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Length: " + Length);
            Console.WriteLine("Width: " + Width);
        }
    }
}
