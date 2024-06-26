namespace ifApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1부터 100까지의 합을 구해라.
            //for문으로

            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += (i+1);
            }
            Console.WriteLine(sum);
        }
    }
}
