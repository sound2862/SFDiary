namespace RandomApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] score = new int[3];
            int total = 0;
            double avg = 0.0;
            Random random = new Random();

            for (int i = 0; i < score.Length; i++) 
            {
                score[i] = random.Next(1, 101);
                total += score[i];
                Console.WriteLine(score[i]);
            }

            avg = (double)total / score.Length;

            Console.WriteLine(avg); 
        }
    }
}
