namespace Quiz015
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("삼각형을 그리다");
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("사각형을 그리다");
        }
    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("원을 그리다");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Shape tri = new Triangle();
            Shape rec = new Rectangle();
            Shape cir = new Circle();
            tri.Draw();
            rec.Draw();
            cir.Draw();
        }
    }
}
