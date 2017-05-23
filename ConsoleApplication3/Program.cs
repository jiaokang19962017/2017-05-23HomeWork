using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new MountainBike();
            (c1 as MountainBike).PlusSpeed();
            (c1 as MountainBike).Match();
        }
    }
}
