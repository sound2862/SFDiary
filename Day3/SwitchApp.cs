using System.Diagnostics;

namespace SwitchApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());

            switch (num)
            {
                case int n when (n >= 90 && n <= 100):
                    Console.WriteLine("A학점입니다.");
                    break;
            }
        }
    }
}
