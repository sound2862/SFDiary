namespace Array01
{
    internal class Program
    {
        //정수형 배열 score를 만들고,
        //순서대로 국어, 영어, 수학 성적을 입력받아
        //총점과 평균을 출력하세요
        static void Main(string[] args)
        {
            int[] score = new int[3];
            int total = 0;
            double aver = 0;

            for (int i = 0; i < score.Length; i++)
            {
                score[i] = Int32.Parse(Console.ReadLine());
                total += score[i];
            }

            aver = (double)total / score.Length;

            Console.WriteLine($"총점 : {total}");
            Console.WriteLine($"평균 : {aver:F2}");
        }
    }
}
