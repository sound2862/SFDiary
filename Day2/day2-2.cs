namespace Day2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //두 정수 v1, v2를 입력받아 그 합을 출력하라.
            Console.WriteLine("정수를 입력하세요");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("정수를 입력하세요");
            int b = int.Parse(Console.ReadLine());

            int r = a + b;

            Console.WriteLine(r);
        }
    }
}
