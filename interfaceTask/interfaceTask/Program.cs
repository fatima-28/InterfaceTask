using System;

namespace classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Fatima Bayramova", "fatimabayramova2002@gmail.com");
            user1.PasswordChecker("2002Fatima");
            user1.ShowInfo();
        }
        public interface IAccount
        {
            public bool PasswordChecker(string password);
            public void ShowInfo();
        }

    }
}
