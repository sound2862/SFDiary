namespace MethodApp04
{
    class Student
    {
        private string subject;
        private int grade;
        public Student()
        {
            this.subject = "";
            this.grade = 90;
        }
        public void EnrollCourse(string subject) //- 수강신청하다
        {
            this.subject = subject;
        }
        public void DropCourse() //-  수강신청 취소하다
        {
            this.subject = "";
        }
        public void ViewGrades() //- 성적확인하기
        {
            Console.WriteLine($"당신의 {subject}성적은 {grade}점 입니다."); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.ViewGrades();
            st.EnrollCourse("수학");
            st.ViewGrades();
            st.DropCourse();
            st.ViewGrades();
        }
    }
}
