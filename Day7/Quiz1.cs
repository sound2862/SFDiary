namespace Quiz1
{
    abstract class Mammal
    {
        public string name;
        public Mammal()
        {
            this.name = "포유류";
        }
        public abstract string Eat();
    }

    class Lion : Mammal
    {
        public Lion()
        {
            this.name = "사자";
        }
        public override string Eat()
        {
            return $"{name}가 먹습니다";
        }
    }

    class Tiger : Mammal
    {
        public Tiger()
        {
            this.name = "호랑이";
        }
        public override string Eat()
        {
            return $"{name}가 먹습니다";
        }
    }

    class Dog : Mammal
    {
        public Dog()
        {
            this.name = "개";
        }
        public override string Eat()
        {
            return $"{name}가 먹습니다";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal[] mammals = { new Lion(), new Tiger(), new Dog() };

            for (int i = 0; i < mammals.Length; i++)
            {
                Console.WriteLine(mammals[i].Eat()); 
            }
        }
    }
}
