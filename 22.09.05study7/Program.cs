using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._05study7
{
    enum Days { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat};
    internal class Program
    {
        static void Main(string[] args)
        {
            int nvalue = (int)Days.Mon;
            Days day = Days.Tue;
            Console.WriteLine("{0} {1}", nvalue, day);
        }
    }
}
