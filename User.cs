using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class User:IAccount
    {
        public int Id { get; set; } 
        public string Fullname { get; set; }    
        public string Email { get; set; }   
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;  
                }
            }
        }
        public static bool PasswordChecker(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password.Length > 8 && char.IsLetter(password[i]) && char.IsUpper(password[i]) && char.IsDigit(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id-{Id} \nFullname -{Fullname } \nemail  -{Email } \nPassword  -{Password }");
        }
    }
}
