namespace OOP06
{
    class Shape
    {
        //멤버변수는 private로
        private string color;
        public string property { get; set; } //C#의 경우 게터 세터의 반복생성을 막기위해 Property를 사용.
                                             //변수처럼 보이는데 "메소드" 다!
    }
    class Circle : Shape
    {
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.property = "red";
        }
    }
}
