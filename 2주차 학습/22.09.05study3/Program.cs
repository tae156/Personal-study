using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._05study3
{
    public struct Mystruct
    {
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mystruct Teststruct1, Teststruct2;
            Teststruct2.Age = 10;
            Teststruct1 = Teststruct2;
            Console.WriteLine("{0}", Teststruct1.Age);

            Mystruct test;
            test = new Mystruct();
            Console.WriteLine(test.Age);
        }
    }
}
