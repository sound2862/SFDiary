namespace Quiz008
{
    internal class Program
    {
        static void Perfect()
        {
            while (true) 
            {
                int num = Int32.Parse(Console.ReadLine());
                int sum = 0;

                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == num)
                {
                    Console.WriteLine("yes");
                }
                else Console.WriteLine("no");
            }
        }

        static void Main(string[] args)
        {
            Perfect();
        }
    }
}
