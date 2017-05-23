using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Car
    {
        private int tyreNum;
        private int maxSpeed;
        private int maxWeight;
        private string type;

        protected int TyreNum
        {
            get
            {
                return tyreNum;
            }

            set
            {
                tyreNum = value;
            }
        }

        protected int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }

            set
            {
                maxSpeed = value;
            }
        }

        protected int MaxWeight
        {
            get
            {
                return maxWeight;
            }

            set
            {
                maxWeight = value;
            }
        }

        protected string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public void PlusSpeed()
        {

        }
    }
}
