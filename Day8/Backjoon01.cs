using System;
using System.Xml;

namespace Backjoon01
{
    internal class Program
    {
        static void measure()
        {
            int read_count = int.Parse(Console.ReadLine());
            string read_num = "";

            string[] qoduf = Console.ReadLine().Split(' '); // 공백 빼고 문자열 배열에 나눠서 넣구
            int[] num = new int[read_count];

            //배열 문자열 받아서 배열 정수로 바꾸고 오름차순으로 정렬하기
            for (int i = 0; i < read_count; i++)  //문자열배열 -> 정수배열
            {
                num[i] = Int32.Parse(qoduf[i]);
            }

            for (int i = 0; i < read_count; i++)  //오름차순 정렬하고 read_num에 집어넣기
            {
                for (int j = i; j < read_count; j++)
                {
                    if (num[j] < num[i])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
                //Console.WriteLine(num[i]);
                read_num += num[i] + " "; 
            }
            // 배열 정리 끝

            // read_count와 배열을 이용해서 약수 구하기 루틴과 비교
            for (int i = 1; i <= 1000000; i++)
            {
                int measure_count = 0;
                string measure = "";

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        measure += j + " ";
                        measure_count++;
                    }
                }

                if (read_count == measure_count && read_num == measure)
                {
                    //Console.WriteLine("ㅇㅋ 성공");
                    //Console.WriteLine($"숫자 : {i}");
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("실패");
        }

        static void Main(string[] args)
        {
            measure();
        }
    }
}
