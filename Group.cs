using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Group
    {
        private int _studentLimit;
        public string GroupNo { get; set; }
        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (value >= 5 && value <= 18)
                {
                    _studentLimit = value;
                       }
            }
        }
        public  Student[] students = new Student[0];
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length-1] = student;  
        }
        public bool CheckGroupNo(string groupNo)
        {
            for (int i = 0; i < groupNo.Length; i++)
            {
                if (groupNo.Length == 5 && char.IsUpper(groupNo[0]) && char.IsDigit(groupNo[2]) && char.IsUpper(groupNo[1]) && char.IsDigit(groupNo[3]) && char.IsDigit(groupNo[4]))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
