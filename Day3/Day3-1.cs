namespace Day3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1~100까지의 3의 배수와 7의 배수만 출력해주세요

            string a1 = "";
            string a2 = "";
            int count2 = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) //3의 배수
                {
                    a1 += i + " ";
                }
                else if (i % 7 == 0) //7의 배수
                {
                    a2 += i+ " ";
                }
            }

            Console.WriteLine(a1);
            Console.WriteLine(a2);
        }
    }
}
