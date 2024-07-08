namespace Quiz009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"N? ");
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) 
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
