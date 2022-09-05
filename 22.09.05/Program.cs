using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._05
{
    public struct Mystruct
    {
        public const float PI = 13.3f; //자동으로 정적변수와 동일하게 적용이 됨
        public static float Age = 10.22f; //static인 정적 변수를 사용하고있음

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} , {1}", Mystruct.PI, Mystruct.Age);
        }
    }
}
