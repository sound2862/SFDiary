namespace RandomApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];
            Random random = new Random();


            //랜덤 할당
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 10);

                for (int j = 0; j < i; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        i--;
                        break;
                    }
                }
            }

            int bonusNumber = numbers[6];
            int[] lottoNumbers = new int[6];
            Array.Copy(numbers, 0, lottoNumbers, 0, 6);

            Array.Sort(lottoNumbers);
            foreach (int i in lottoNumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"보너스번호 : {bonusNumber}");

        }
    }
}
