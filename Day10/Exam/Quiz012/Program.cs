namespace Quiz012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numArray = new int[5];

            for (int i = 0; i < numArray.Length; i++) 
            {
                numArray[i] = random.Next(1, 10);
                Console.Write($"{numArray[i]} ");
            }
        }
    }
}
