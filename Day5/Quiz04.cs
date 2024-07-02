namespace Quiz04
{
    internal class Program
    {
        static int GetMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            return min;
        }
        static int GetMax(int[] arr)
        {
            int max = arr[0];


            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
            int[] arr = { -7, 5, 60, -33, 42 };

            Console.WriteLine($"최대값은 : {GetMax(arr)}");
            Console.WriteLine($"최솟값은 : {GetMin(arr)}");
        }
    }
}
