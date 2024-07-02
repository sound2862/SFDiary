namespace ScoreApp02
{
    //국어 영어 수학 성적을 입력하면, 합계(TotalScore)와 평균(average)을 출력
    internal class Program
    {
        static int[] InputThreeScore()
        {
            int[] score = new int[3];

            for (int i = 0; i < score.Length; i++)
            {
                score[i] = Int32.Parse(Console.ReadLine());
            }

            return score;
        }

        static int TotalScoer(int[] arr)
        {
            int totalScore = 0;

            foreach (int i in arr)
            {
                totalScore += i;
            }

            return totalScore;
        }

        static double GetAvg(int totalScore)
        {
            return totalScore/3.0;
        }

        static void Main(string[] args)
        {
            int[] score = InputThreeScore();
            int total = TotalScoer(score);
            double avg = GetAvg(total);

            Console.WriteLine($"총점 : {total}");
            Console.WriteLine($"평균 : {avg:f2}");

        }
    }
}
