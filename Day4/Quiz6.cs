namespace Quiz6
{

    //국,영,수 성적을 입력받아 총점을 구하는 프로그램을 메소드로 만들어봅시다.
    //1.성적을 입력받는 메소드 만들기
    //조건 - return Type이 정수형 배열
    //2.총점을 구하는 메소드를 작성하세요
    //조건 - return Type이 정수형
    internal class Program
    {
        static int[] InputScore()
        {
            int[] I_score = new int[3];
            for (int i = 0; i< I_score.Length; i++)
            {
                I_score[i] = Int32.Parse(Console.ReadLine()); 
            }

            return I_score;
        }

        static int GetSum(int[] G_score)
        {
            int G_sum = 0;

            for (int i = 0; i<G_score.Length; i++)
            {
                G_sum += G_score[i];
            }

            return G_sum;
        }

        static double GetAver(int[] A_score)
        {
            double sum = 0;

            for (int i = 0; i < A_score.Length; i++)
            {
                sum += A_score[i];
            }

            return sum / A_score.Length;
        }

        static void Main(string[] args)
        {
            int[] score = InputScore();

            int sum = GetSum(score);
            double aver = GetAver(score);

            Console.WriteLine($"총점 : {sum}");
            Console.WriteLine($"평균 : {aver}");
        }
    }
}
