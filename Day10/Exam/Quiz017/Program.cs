namespace Quiz017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            do
            {
                Console.WriteLine("1.데이터 삽입");
                Console.WriteLine("2.데이터 삭제");
                Console.WriteLine("3.데이터 조회");
                Console.WriteLine("4.데이터 수정");
                Console.WriteLine("5.프로그램 종료");
                Console.WriteLine("");
                Console.Write("메뉴 : ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice) 
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("프로그램이 종료됩니다.");
                        break;
                }

            } while(choice != 5);
        }
    }
}
