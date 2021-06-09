using System;

namespace ShapeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(5);
            TestShape(s);
        }


        // Since shape is the parent of all child classes, 
        // any child of shape is welcome here.
        // This is an example of polymorphism in action.
        public static void TestShape(Shape s)
        {
            s.PrintInfo();
            int area = s.CalculateArea();
            int perimeter = s.CalculatePerimeter();
        }
    }
}
