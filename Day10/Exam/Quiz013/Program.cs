namespace Quiz013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>();

            while (list.Count < 7) 
            {
                int num1 = random.Next(1, 42);
                if (!list.Contains(num1))
                {
                    list.Add(num1);
                }
            }
            int bonusNum = list[0];

            list.RemoveAt(0);
            list.Sort();
            Console.Write("로또 번호 : ");

            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"보너스 번호 : {bonusNum}");
        }
    }
}
