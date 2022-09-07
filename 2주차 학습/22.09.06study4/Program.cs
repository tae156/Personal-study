using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._06study4
{
    class A
    {

    }
    class B
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123";
            object obj1 = str1;
            string str2 = obj1 as string;
            Console.WriteLine(str2);

            A Test1 = new A();
            object obj2 = Test1;
            B Test2 = obj2 as B;
            if (Test2 == null)
                Console.WriteLine("호환 실패");
            else
                Console.WriteLine("호환 성공");
        }
    }
}
