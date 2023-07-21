using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcNunitEx1Day10
{
    public class Calc
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Multi(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
        static int x= 2;
        public bool IsPrime(int a)
        {
            if (a==0 || a==1) return false;
            if(a==x) return true;
            if(a%x==0) return false;
            x++;
            return IsPrime(a);
        }
      
    }
}
