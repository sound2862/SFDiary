namespace ArrayApp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            int cnt = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = cnt++;
                }
            }

            for (int i = 0; i< 3; i++)
            {
                for(int j = 0;j < 3; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
