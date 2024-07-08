namespace Quiz014
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] list = { 4, 5, 7, 3, 2, 1, 9, 8 };
            int temp;
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = 0; j < list.Length - 1 - i ; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            foreach (int i in list)
                Console.WriteLine(i);
        }
    }
}

