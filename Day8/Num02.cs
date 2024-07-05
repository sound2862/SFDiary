namespace Num02
{
    internal class Program
    {
        static string prime()
        {
            string result= "";
            int test = 0;
            for (int i = 2; i < 100; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        test++;
                        break;
                    }
                }
                if (test == 0)
                {
                    result += i + " ";
                }
                test = 0;
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(prime());
        }
    }
}
