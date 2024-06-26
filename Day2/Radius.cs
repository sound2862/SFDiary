namespace Radius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //반지름을 입력받으면 원 넓이를 구해주는 프로그램을 작성.
            //단, 소수점 둘때자리까지만 출력.
            //단, 원주율은 Math클래스를 이용

            double radius;
            double area;

            Console.Write("반지름을 입력하세요 : ");
            radius = double.Parse(Console.ReadLine());
            area = Math.PI * radius * radius;

            Console.WriteLine($"반지름 : {radius}");
            Console.WriteLine($"넓이 : {area:f2}");
        }
    }
}
