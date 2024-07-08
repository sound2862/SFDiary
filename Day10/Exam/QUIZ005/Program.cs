namespace QUIZ005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 9; i > 1; i--) 
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
            }
        }
    }
}
