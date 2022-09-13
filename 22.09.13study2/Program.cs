using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._13study2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nArray1 = { 1,2,3,4,5}; // 배열의 범위 0,1,2,3,4 이다
            Array.Clear(nArray1, 2, 3); //2는 배열의 2번째 부터 3개까지  0으로 초기화
            foreach(int m in nArray1)
                Console.Write(m);
            Console.WriteLine();

            Array.Clear(nArray1, 0, nArray1.Length);// 0은 배열의 0번째 부터 nArray 배열 범위까지 0으로 초기화  
            foreach (int n in nArray1)
                Console.Write(n);
            Console.WriteLine();
            
        }
    }
}
