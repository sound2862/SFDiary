namespace TestApp02
{
    class User
    {
        private readonly string userID;
        private readonly string userPW;

        public User(string userID, string userPW)
        {
            this.userID = userID;
            this.userPW = userPW;
        }
        public void Print()
        {
            Console.WriteLine(userID);
            Console.WriteLine(userPW);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string uID = "sound2862";
            string uPW = "asdf";

            User user = new User(uID, uPW);
        }
    }
}
