using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._05study6
{
    public struct Mystruct
    {
        public int Kor, Eng, Math, Total1;
        public float Average;

        public void Computer()
        {
            Total1 = Kor + Eng + Math;
            Average = Total1 / 3.0f;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mystruct Test1 = new Mystruct();
            Test1.Kor = 80;
            Test1.Eng = 99;
            Test1.Math = 100;
            Test1.Computer();
            Console.WriteLine("총점 : {0}  평균: {1}",Test1.Total1, Test1.Average);
        }
    }
}
