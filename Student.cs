using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student
    {
        private int _id;
        public int Id { get; } 
        public string Fullname { get; set; }    
        public double Point { get; set; }   
        public void StudentInfo()
        {
            Console.WriteLine($"Id-{Id} \nFullname -{Fullname } \nPoint  -{Point }");
        }
        public Student(string fullname ,double point)
        {
            _id++;
            Id = _id;
        }
    }
}
