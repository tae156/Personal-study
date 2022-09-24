using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._24study1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "국어: 90 영어: 100 수학: 70";
            string[] str_Element = str.Split(new char[] { ' ' });
            // 배열의 크기 인 국어=0번째, 90=1번째, 영어=2번째, 100=3번쨰로 나누어진다.
            int kor = int.Parse(str_Element[1]);//90
            int eng = int.Parse(str_Element[3]);//100
            int math = int.Parse(str_Element[5]);//70
            int total = kor + eng + math;
            float average = total / 3.0f;
            Console.Write("{0} {1} {2} {3}",kor, eng, math, Math.Round(average));
            //Math은 일반 수학 함수에 대한 상수 및 정적 메소드를 재공하는 것이다.

        }
    }
}
