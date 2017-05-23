using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student1
    {
        private string Name;
        private int Age;

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

        public void AboutMe()
        {
            Console.WriteLine("我的名字是{0},今年{1}岁了",Name1,Age1);
        }
        public Student1(int age,string name)
        {
            if (age < 16)
            {
                Console.WriteLine("错误");
            }
            else {
            this.Age = age;
            this.Name = name;
            }  
        }
    }
}
