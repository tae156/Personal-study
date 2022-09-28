using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._28study1
{
    class Date
    {
        internal int Day;
        public int Year, Month;
        //예시
        //private int Day = 클래스 내부에서 사용가능
        //protected int Day = 클래스 내부에서 사용이 가능하고 
        //하위 클래스 안에서는 상위 protected멤버에 접근 가능함
        public void Print()
        {
            Console.WriteLine("{0} {1} {2}", Year, Month, Day);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date();
            date.Year = 2022;
            date.Month = 1;
            date.Print();
            date.Day = 100;
        }
    }
}
