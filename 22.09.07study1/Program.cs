using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._07study1
{
    internal class Program
    {
        static void Main(string[] args)//배열을 이용한 반복문으로 출력하는 내용
        {
            int[] array = { 1, 2, 3, 4 };
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }

            foreach(int m in array) 
                Console.WriteLine("{0}", m);

            string[] mr = { "월", "화", "수", "목", "금", "토", "월" };
            foreach (string str in mr)
                Console.WriteLine(str + " ");
        }
    }
}
