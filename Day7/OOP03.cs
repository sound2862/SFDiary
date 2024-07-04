namespace OOP03
{
    class Shape
    {
        public string name;
        public Shape()
        {
            this.name = "도형";
            Console.WriteLine("부모클래스 생성자");
        }

        public virtual void Draw()
        {
            Console.WriteLine("도형을 그리다");
        }
    }

    class Rectangle : Shape
    {
        public Rectangle() 
        {
            this.name = "사각형";
            Console.WriteLine("자식클래스 생성자");
        }

        public override void Draw()
        {
            Console.WriteLine("네모를 그리다");
        }
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Console.WriteLine(r.name);
        }
    }
}
