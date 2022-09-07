using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._06study9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int[] Array = { 1, 2, 3, 4, 5, 6, };
            foreach( int value in Array) // 순서대로 나열되어있는 값을 표출
            {
                Console.WriteLine(value);
            }*/
           
            //데이터형 또는 클래스 단위를 순차적으로 나열할 때 사용되는 내용
            ArrayList List = new ArrayList();
            List.Add(1);
            List.Add(2);
            List.Add(3);
            foreach(int m in List)
            {
                Console.WriteLine(m);
            }

        }
    }
}
