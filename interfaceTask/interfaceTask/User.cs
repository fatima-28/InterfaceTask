using System;
using System.Collections.Generic;
using System.Text;
namespace classwork
{
    public class User : IAccount
    {
        public string Fullname;
        public string Email;
        public string Password;
        public User()
        {
            Console.WriteLine("Email yaratmaqiniz mecburidir!");
        }
        public User(string fullname, string email)
        {
            Email = email;
            Fullname = fullname;

        }

        public bool PasswordChecker(string password)
        {
            bool IsPassword = false;
            int TrueCount = 0;
            if (password.Length >= 8)//8li sifre 1 boy 1 kicik herf 1 reqem
            {
                for (int i = 0; i < password.Length; i++)
                {
                    char character = password[i];
                    int digit = password[i];
                    if (password[i] == Char.ToUpper(character))
                    {

                        TrueCount++;

                    }
                    else
                    {
                        Console.WriteLine("Invalid password");
                        break;
                    }

                    if (password[i] == Char.ToLower(character))
                    {

                        TrueCount++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid password");
                        break;
                    }
                    if (password[i] == digit)
                    {
                        TrueCount++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid password");
                        break;
                    }
                }
            }
            if (TrueCount >= 3)
            {
                IsPassword = true;
            }
            else
            {
                IsPassword = false;
            }

            return IsPassword;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"User fullname: {Fullname} , User email: {Email}");
        }
    }
}
