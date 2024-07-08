namespace Quiz007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string result = "";

            for (int i = 2; i < 100; i++) 
            {
                for (int j = 2; j < i; j++) 
                {
                    if(i % j  == 0)
                    {
                        count++ ;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.Write($"{i} ");
                }
                count=0;
            }
        }
    }
}
