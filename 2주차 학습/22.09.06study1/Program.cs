using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._06study1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool BFlag = false;
            Console.WriteLine("{0} {1} {2}", !BFlag, !true, !false);
            //!BFlag false로 초기화 되어있으니 앞 다항연자사를 사용했을 때 true로 변경된다.

        }
    }
}
