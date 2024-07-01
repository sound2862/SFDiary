using System.Diagnostics;

namespace SwitchApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("입력해주세요. (1.사과 2.배 3.오렌지)... : ");
            int num = Int32.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("사과입니다.");
                    break;
                case 2:
                    Console.WriteLine("배입니다.");
                    break;
                case 3:
                    Console.WriteLine("오렌지입니다.");
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }
        }
    }
}
