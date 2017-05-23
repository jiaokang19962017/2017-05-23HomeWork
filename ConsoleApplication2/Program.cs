using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            //声明第一个对象,有参的方式
           Student2 stu = new Student2('男', ".net");
            stu.AboutMe();


            //声明第二个对象,无参的方式
            Student2 stu1 = new Student2();
            stu1.Name1 = "jiaokang";
            stu1.Age1 = 21;
            stu1.Sex1 = '男';
            stu1.Major1 = ".net";
            stu1.AboutMe();
        }
    }
}
