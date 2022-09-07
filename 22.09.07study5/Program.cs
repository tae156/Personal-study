using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._07study5
{
    internal class Program
    {
        static void Array(string[] arr) //참소 변수를 생성하여 영문을 한문으로 변경하는 내용
        {
            string[] Han = { "월", "화", "수", "목", "금", "토", "일" };
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Han[i];
            }
        }
        static void Main(string[] args)
        {
            string[] date = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            Array(date);
            foreach(string str in date)
            {
                Console.WriteLine(str + " ");
            }
        }
    }
}
