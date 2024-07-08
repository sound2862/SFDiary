namespace Quiz020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("전체 개수(N) : ");
            int N = Int32.Parse(Console.ReadLine());
            Console.Write("없앨 개수(K) : ");
            int K = Int32.Parse(Console.ReadLine());
            double avg1 = 0;
            double avg2 = 0;

            List<double> list = new List<double>();
            List<double> list2 = new List<double>();
            
            while (list.Count < N) 
            {
                Console.Write("점수 : ");
                double asdf = double.Parse(Console.ReadLine());
                list.Add(asdf);
                list2.Add(asdf);
            }
            //절사평균
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    list.RemoveAt(j);
                    list.RemoveAt(N - K - j);
                }
            }
            double a = list.Average();
            //보정평균
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    list2[j] = list2[i + K];
                    list2[N - K-j] = list2[N - 1 - K];
                }
            }
            double b = list2.Average();

            Console.WriteLine($"절사평균 : {a:f2}");
            Console.WriteLine($"보정평균 : {b:f2}");

        }
    }
}
