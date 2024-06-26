namespace CtoF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //화씨 온도 = 9 / 5 * 섭씨온도 + 32
            //입력은 1~100사이의 자연수
            //출력은 소수점 둘째자리까지

            int C;
            double F;

            C = int.Parse(Console.ReadLine());

            if (C < 1 | C > 100)
            {
                Console.WriteLine("1부터 100까지의 정수중에 적어주세요.");
                return;
            }

            F = (C*9.0/5.0) + 32;

            Console.WriteLine(F.ToString("0.##"));
        }
    }
}
