using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._05study2
{
    public struct Mystruct
    {
        public int Age;
        public Mystruct(int InAge)
        {
            Age = InAge;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mystruct TestStruct1;
            TestStruct1.Age = 12;
            Console.WriteLine(TestStruct1.Age);

            Mystruct Teststruct2 = new Mystruct();
            Console.WriteLine(Teststruct2.Age);

            Mystruct Teststruct3 = new Mystruct();
            Console.WriteLine(Teststruct3.Age);
        }
    }
}
