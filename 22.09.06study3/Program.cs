using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._06study3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            if (value is float)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환되지 않음");

            if (value is object)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환되지 않음");

            object obj = value;
            if (obj is int)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환되지 않음");

            //이 작업은 함수를 변환할 때 사용이 가능 부분인지 체크?? 조사하는 부분이다.
        }
    }
}
