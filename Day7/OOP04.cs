using System.Diagnostics;

namespace OOP04
{
    abstract class Shape
    {
        public virtual void Draw() { Console.WriteLine("도형을 그리다"); }
    }

    class Triangle : Shape
    {
        public override void Draw() { Console.WriteLine("삼각형을 그리다"); }
    }

    class Rectangle : Shape
    {
        public override void Draw() { Console.WriteLine("사각형을 그리다"); }
    }

    class Circle : Shape
    {
        public override void Draw() { Console.WriteLine("원을 그리다"); }
    }


    internal class Program
    {
        static void Main(string[] args) 
        {
            Shape shape = new Shape();
            Triangle triangle = new Triangle();
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            shape.Draw();
            triangle.Draw();
            rectangle.Draw();
            circle.Draw();

        }
    }
}
