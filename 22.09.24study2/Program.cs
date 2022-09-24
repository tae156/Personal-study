using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._24study2
{
    internal class Program
    {
        struct GRADE//구조체 선언
        {
            public int kor, eng, math, total;
            public int average;
        }

        static void Main(string[] args)
        {
            string str;
            float average;
            Console.Write("성적 처리를 위한 학생 수를 입력해 주세요:");
            int nCount = int.Parse(Console.ReadLine());

            Console.WriteLine("국어 영어 수학 순서로 입력해 주세요:");
            GRADE[] grade = new GRADE[nCount];
            StreamWriter sw = new StreamWriter("test.txt");
            sw.WriteLine("학생수: {0} ", nCount);


            for(int i= 0; i< nCount; i++)
            {
                str = Console.ReadLine();
                string[] DataString = str.Split(new char[] { ' ' });
                grade[i].kor = int.Parse(DataString[0]);
                grade[i].eng = int.Parse(DataString[1]);
                grade[i].math = int.Parse(DataString[2]);
                grade[i].total = grade[i].kor + grade[i].eng + grade[i].math;
                average = grade[i].total / 3.0f;
                grade[i].average = (int)Math.Round(average);//.Round메소드안의 데이터에 대한 값을 반올림한다.
            }

            for (int i = 0; i < nCount; i++) //데이터를 파일에 담는곳
            
                sw.WriteLine("국어: {0},영어: {1},수학: {2},총점: {3},평균: {4:f1}",
                    grade[i].kor, grade[i].eng, grade[i].math, grade[i].total, grade[i].average);
                sw.Close();
            
        }
    }
}
