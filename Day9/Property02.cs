namespace Property02
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("이름이 입력되지 않았습니다");
                }
                else name = value;

            }
        }
        class Student
        {
            public string Name { get; set; } = "아무개";
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Person ps = new Person();
                ps.Name = "Test";
                Console.WriteLine(ps.Name);
            }
        }
    }
}
