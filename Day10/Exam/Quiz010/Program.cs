namespace Quiz010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"N? ");
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = 0 ; j < N - i-1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0 ; k <= i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
//2 1 0 
//1 3 5 

//1 2 3 

