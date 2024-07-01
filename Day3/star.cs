namespace Star
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요 : ");
            int num = Int32.Parse(Console.ReadLine());
            int middle = (num - 1) / 2;

            for (int i = 0; i < num; i++)
            {
                for (int k = middle; k > i; k--)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < i - middle; k++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }


                Console.WriteLine();

                
            }
        }
    }
}
