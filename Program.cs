using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool chek = true;
            Group group = null;
            do
            {

                User user = new User();
                Console.WriteLine("fullname daxil edin :");
                user.Fullname = Console.ReadLine();
                Console.WriteLine("Email daxil edin :");
                user.Email = Console.ReadLine();
                Console.WriteLine("Password daxil ediin :");
                user.Password = Console.ReadLine();
                Console.WriteLine("  1. Show info");
                Console.WriteLine("  2. Create new group");
                int num = Convert.ToInt32(Console.ReadLine());   
                switch (num)
                {
                    case 1:
                        user.ShowInfo();
                        break;
                    case 2:
                        Console.WriteLine("fullname daxil edin :");
                        user.Fullname = Console.ReadLine();
                        Console.WriteLine("Email daxil edin :");
                        user.Email = Console.ReadLine();
                        Console.WriteLine("Password daxil ediin :");
                        user.Password = Console.ReadLine();
                        break;
                    case 3: Console.WriteLine("   1.Show all students");
                        Console.WriteLine(" 2.Get student by id");
                        Console.WriteLine("   3.Add student");
                        Console.WriteLine("    0.Quit");
                        Console.WriteLine(  "menydan bir eded daxil edin  :");
                        int num1=Convert.ToInt32(Console.ReadLine());
                        break;
                }
            } while (chek);
            Console.ReadLine(); 
        }   
    }
}
