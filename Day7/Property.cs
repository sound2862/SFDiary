namespace Property
{
    class Person
    {
        private string name;
        private int age;

        //Property
        public string Name { get; set; }  //보통은 이렇게 만든다
        //public string Name                  //열어보면 이런느낌
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value;
        //    }
        //}

        public int Age                       //수정하려면 이렇게 ㅇㅇ
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 20)
                {
                    age = value;
                }
                else;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person paul = new Person();
            paul.Name = "파울이";
            paul.Age = 23;

            Console.WriteLine($"{paul.Name} 나이 : {paul.Age}");
        }
    }
}
