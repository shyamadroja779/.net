using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    interface  Calculater
    {
        int Addition(int a, int b);
        int Subtraction(int a, int b);
    }

    class Result : Calculate
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
}
