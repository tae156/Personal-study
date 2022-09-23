using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._23study3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("text.txt", FileMode.Open, FileAccess.Read);//파일 읽기로만 사용하겠다.
            StreamReader sr = new StreamReader(fs);
            int value = int.Parse(sr.ReadLine()); // 문자열로 읽어들임
            float value2 = float.Parse(sr.ReadLine());
            string str1 = sr.ReadLine();
            sr.Close();
            Console.WriteLine("{0}, {1}, {2}", value, value2, str1);

        }
    }
}
