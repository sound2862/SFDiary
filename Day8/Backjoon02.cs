namespace Backjoon02
{
    internal class Program
    {
        static void measure()
        {
            int num = int.Parse(Console.ReadLine());
            

            string[] array = Console.ReadLine().Split(' ');
            int[] numArray = new int[num];
            int result;

            for (int i = 0; i < num; i++)  //문자열배열 -> 정수배열
            {
                numArray[i] = Int32.Parse(array[i]);
            }

            for (int i = 0; i < num; i++)  //오름차순 정렬하고 read_num에 집어넣기
            {
                for (int j = i; j < num; j++)
                {
                    if (numArray[j] < numArray[i])
                    {
                        int temp = numArray[i];
                        numArray[i] = numArray[j];
                        numArray[j] = temp;
                    }
                }
            }

            result = numArray[0] * numArray[num-1];
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            measure();
        }
    }
}
