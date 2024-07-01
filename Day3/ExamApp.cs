namespace ExamApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q) for문 100 ~ 1까지 거꾸로 출력해보세요.
            //짝수만 출력

            for (int i = 100; i > 0; i--) 
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }


            Console.WriteLine(); // for문과 while문의 구간 나누기 및
            Console.WriteLine(); 
            int j = 100;         // while문을 위한 j 선언, 초기화

            while (j > 0)
            {
                if(j % 2 == 1)
                {
                    Console.Write(j + " ");
                }
                j--;
            }
        }
    }
}
