using System.ComponentModel;

namespace Num01
{
    internal class Program
    {
        static void PerfectNumber()
        {
            bool flag = false; //플래그 변수

            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag == false) { Console.WriteLine(i); }
                flag = false;
            }
        }
        static void Main(string[] args)
        {
                PerfectNumber();
        }
    }
}
