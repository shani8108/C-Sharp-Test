using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Test
{
    internal class exercise_8
    {
        public int Calc(int a)
        {
            return a * a;
        }
        public int Calc(int a,int b)
        {
            return a * b;
        }
        public int Calc(string a)
        {
            return 0;
        }
        public void Calc(string a, string b)
        {
            Console.WriteLine(a+b);
        }
        public void Run()
        {
            int a=Calc(1, 2);
            int b=Calc(2);
            int c=Calc("No Calc");
            Calc("No Calc","No Return");
        }
    }
}
