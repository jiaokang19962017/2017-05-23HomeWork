using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class Books
    {
        private string Title;
        private int PageNum;
        private string Type;

        public string Title1
        {
            get
            {
                return Title;
            }

            set
            {
                Title = value;
            }
        }

        public int PageNum1
        {
            get
            {
                return PageNum;
            }

            set
            {
                PageNum = value;
            }
        }

        public string Type1
        {
            get
            {
                return Type;
            }

            set
            {
                Type = value;
            }
        }

        public void Detail()
        {
            Console.WriteLine("教材的名称是{0},页数是{1},类型是{2}",Title,PageNum,Type);
        }

        public Books(string title,int pageNum)
        {
            this.Type = "计算机";
            this.Title = title;
            this.PageNum = pageNum;
        }
        public Books(string title, int pageNum,string type)
        {
            this.Type = type;
            this.Title = title;
            this.PageNum = pageNum;
        }
    }
}
