using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._06study2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "3" + ".14";
            Console.WriteLine(+5); //양 5 (거의 사용되지 않음
            Console.WriteLine(5+5);// 양 10
            Console.WriteLine(5+.5);// 소수 5.5
            Console.WriteLine("5" + "5"); // 문자열 연결식 55
            Console.WriteLine(5.01f + "5");// 문자열 연결식 5.015
            Console.WriteLine(3.14f + "5");//문자열 연길식 3.145
            Console.WriteLine(str);

            str = 1 + "test" + 3.14 + "abcd";
            Console.WriteLine(str);
        }
    }
}
