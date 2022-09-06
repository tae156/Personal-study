using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._06studyA11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] array = { 1, 2, 3 };
            try
            {
                Console.WriteLine("예외처리 발생");
                array[3] = 10; 
            } //catch문을 넣지 않아도 CRL에서 에러 표시를 해줌
            finally
            {
                Console.WriteLine("array[3] = 10을 넣었다");
            }*/

            int i = 0;
            try
            {
                i = 12;
            }
            finally
            {
                i = 100;
                Console.WriteLine("finally 문 i값: {0}", i);
            }
            i = 200;
            Console.WriteLine("try ~ finally 밖의 초기 값: {0}", i);
        }
    }
}
