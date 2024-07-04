namespace quiz04
{
    internal class Program
    {
        static string odd()
        {
            string result = "";
            int index = 0;

            for (int i = 1; i <= 100; i+=2)
            {
                result += i+" ";
            }

            return result;
        }

        static string AtoZ()
        {
            string result = "";

            for (int i = 'A'; i < 'Z'; i++)
            {
                result += (char)i+" ";
            }

            return result;
        }

        static int GCD()
        {
            int a = 18;
            int b = 8;

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("[ 문제 ]");
                Console.WriteLine("﻿1. 1 ~ 100까지 홀수만 출력합니다. ");
                Console.WriteLine("2. 알파벳 A ~ Z / a ~ z 까지 출력합니다.");
                Console.WriteLine("3. 12와 18의 최대공약수(GCD)를 구해봅니다.");
                Console.WriteLine("4. 프로그램을 종료합니다.");
                Console.Write("선택 : ");

                choice = int.Parse(Console.ReadLine()); 

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(odd());
                        break;
                    case 2:
                        Console.WriteLine(AtoZ());
                        Console.WriteLine(AtoZ().ToLower());
                        break;
                    case 3:
                        Console.WriteLine(GCD());
                        break;
                    case 4:
                        Console.WriteLine("프로그램을 종료합니다.");
                        break;
                    default:
                        Console.WriteLine("잘못된 숫자를 입력하였습니다.");
                        break;
                }
            } while (choice != 4);
        }
    }
}
