namespace VariableChange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Pi = 3.141592;
            char c = 'A';           //ASCII --> 65
            char d = (char)65;
            Console.WriteLine($"{Pi} {c} {d}");

            //홀수 짝수 구분
            int e = 7;
            if (e % 7 == 0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }

            //스위치 케이스 문
            int s1=1, s2=2, s3=3;
            int value = s2;
            switch (value)
            {
                case 1:
                    Console.WriteLine(value);
                    break;
                case 2:
                    Console.WriteLine(value);
                    break;
                default:
                    Console.WriteLine(value);
                    break;
            }
        }
    }
}
