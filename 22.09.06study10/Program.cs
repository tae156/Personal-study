using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._06studyA10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] Array = { 1, 2, 3 };// 배열 데이터 순서는 0부터 시작
            try
            {
                Array[3] = 10;
            }
            catch(IndexOutOfRangeException e) 
            {
                Console.WriteLine("예러 발생");
                Console.WriteLine(e.ToString());
                Array[2] = 10;
            }
            for(int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("{0}", Array[i]);
            }
            //데이터 집합에 마지막 초기값을 설정하는 시나리오 방식이였던거*/

            int m; //이 데이터형은 지역변수를 사용하고 있음
            try
            {
                m = 12;
                Console.WriteLine("{0}",m);
            }
            catch
            {
                Console.WriteLine("예외 발생");
            }
            Console.WriteLine("try문 밖에서 변수 출력 {0}", m);
            //현제 초기 값을 가지고 있지 않아 에러 표출이 되고 있는데
            //try안에서 초기값이 이루어지고 있고 그 외 밖에서 사용이 불가능하다.

        }
    }
}
