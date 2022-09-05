using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._05study4
{
    public struct Mystruct
    {
        public int Age;
    }
    class MyClass
    {
        public int Age;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mystruct Test1 = new Mystruct();
            Test1.Age = 12;
            Mystruct Test2 = Test1;
            Test2.Age = 24;
            Console.WriteLine("{0} {1}", Test1.Age, Test2.Age);

            MyClass Test3 = new MyClass();
            Test3.Age = 12;
            MyClass Test4 = Test3;
            Test4.Age = 24;
            Console.WriteLine("{0} {1}", Test3.Age, Test4.Age);
        }
    }
}
