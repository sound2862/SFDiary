namespace Day2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greet;       //변수 선언
            Console.WriteLine("이름 입력하세요");
            greet = Console.ReadLine();     //값 할당, 초기화

            Console.WriteLine($"{greet}님 안녕하세요");       //출력
        }
    }
}
