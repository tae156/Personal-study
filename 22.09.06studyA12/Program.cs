using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._06studyA12
{
    internal class Program
    {
        static int GetNumber(int index)
        {
            int[] num = { 300, 600, 900 };//배열의 집합체는 0,1,2 이다.
            if(index >= num.Length)
            {
                throw new IndexOutOfRangeException();//임의적으로 예외처리 만듬
            }
            return num[index];
        }
        static void Main(string[] args)
        {
            int value = GetNumber(3); //배열의 집합체의 값을 3을 불러옴
        }
    }
}
