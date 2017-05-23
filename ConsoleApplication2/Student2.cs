using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Student2
    {
        /// <summary>
        ///声明字段 
        /// </summary>
        private string Name;
        private int Age;
        private char Sex;
        private string Major;



        /// <summary>
        /// 构造函数:可以用ctrl+r和ctrl+e快速生成
        /// </summary>
        public string Name1
        {
            get
            {
                return Name;
            }

            set
            {
                Name = value;
            }
        }

        public int Age1
        {
            get
            {
                return Age;
            }

            set
            {
                Age = value;
            }
        }

        public char Sex1
        {
            get
            {
                return Sex;
            }

            set
            {
                Sex = value;
            }
        }

        public string Major1
        {
            get
            {
                return Major;
            }

            set
            {
                Major = value;
            }
        }


        /// <summary>
        /// 有参的构造函数
        /// </summary>
        /// <param name="sex">性别</param>
        /// <param name="major">专业</param>
        public Student2(char sex,string major)
        {
            this.Sex = sex;
            this.Major = major;
        }

        /// <summary>
        /// 无参的构造函数
        /// </summary>
        public Student2()
        {

        }

        /// <summary>
        /// 介绍自己的方法
        /// </summary>
        public void AboutMe()
        {
            Console.WriteLine("我的名字是{0},今年{1}岁,性别是{2},专业是{3}",Name,Age,Sex,Major);
        }
    }
}
