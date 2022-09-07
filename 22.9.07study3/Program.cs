using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._9._07study3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[2][]; //행 메모리값: 2
            array[0] = new int[]{ 1,2,3}; //여기서 열의 메모리 값은 3이란 것을 알 수 있음
            array[1] = new int[]{ 4,5,6 };

            for(int i = 0; i< array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
            }
        }
    }
}
