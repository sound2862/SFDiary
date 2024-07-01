namespace Quiz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //성적을 입력하면 학점을 출력합니다. 
            //90~100 = A학점. 80~89=B.70~79=C.60~69=D. 59~=F.
            //점수 : 93
            //A 학점입니다.

            int grade = Int32.Parse(Console.ReadLine());
            String grade_mark = "";

            if (grade <= 100 && grade >= 90)
            {
                grade_mark = "A";
            }
            else if (grade >= 80)
            {
                grade_mark = "B";
            }
            else if (grade >= 70)
            {
                grade_mark = "C";
            }
            else if (grade >= 60)
            {
                grade_mark = "D";
            }
            else
            {
                grade_mark = "F";
            }

            Console.WriteLine("점수 : " + grade);
            Console.WriteLine(grade_mark + " 학점입니다");

        }
    }
}
