using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._05study5
{
    public struct Mystruct
    {
        public int Age;
        public float Num2;
        public bool IsReady;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mystruct Test1 = new Mystruct();
            Console.WriteLine("{0} {1} {2}", Test1.IsReady, Test1.Age, Test1.Num2);
        }
    }
}
