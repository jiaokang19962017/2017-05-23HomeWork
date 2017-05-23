using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Student
    {
        private int num;
        private string name;
        private char sex;

        protected int Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }

        protected string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        protected char Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public Student()
        {

        }
        public void ShowMe()
        {
            Console.WriteLine("我学号{0},姓名是{1},性别是{2}",Num,Name,Sex);
        }
    }
}
