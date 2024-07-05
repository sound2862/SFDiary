namespace OOPApp06
{
    class Shape
    {
        public int vertex; //멤버변수

        public Shape()  //디폴트 생성자
        {
            vertex = 0;
        }
        public void ShowVertext()
        {
            Console.WriteLine(vertex);
        }
        public void ShowVertext(string msg)
        {
            Console.WriteLine($"{msg} {vertex}");
        }
        public void ShowVertext(string msg, string position, int repeat)
        {
            Console.WriteLine($"{msg} {vertex} {position} 반복횏수는 {repeat}");
        }
        public virtual void ShowName()
        {
            Console.WriteLine("도형입니다");
        }

    }
    class Triangle : Shape
    {
        public Triangle()
        {
            vertex = 3;
        }
        public void ShowName()
        {
            Console.WriteLine("삼각형입니다");
        }
    }
    class Circle : Shape
    {
        public void ShowName()
        {
            Console.WriteLine("원입니다");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();
            Circle circle = new Circle();

            triangle.ShowVertext();
            triangle.ShowVertext("꼭지점의 개수는", "냐냥", 3);
            triangle.ShowName();
            circle.ShowName();
        }
    }
}
