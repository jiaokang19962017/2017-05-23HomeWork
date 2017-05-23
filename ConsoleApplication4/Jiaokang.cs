using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Jiaokang:Student
    {
        private int Score1;
        private int Score2;

        public int Score11
        {
            get
            {
                return Score1;
            }

            set
            {
                Score1 = value;
            }
        }

        public int Score21
        {
            get
            {
                return Score2;
            }

            set
            {
                Score2 = value;
            }
        }

        public Jiaokang()
        {

        }
        public void Sum(int score1,int score2)
        {
            Console.WriteLine("总成绩:{0}",score1+score2);
           
        }
        public void Avg(int score1,int score2) {
            Console.WriteLine("平均成绩{0}", (score1 + score2) / 2);
        }
    }
}
