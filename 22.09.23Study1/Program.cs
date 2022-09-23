using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._23Study1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 12;
            float value2 = 3.14f;
            string str1 = "Hello World";
            FileStream fs = new FileStream("test.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(value);
            sw.Write(value2);
            sw.Write(str1);
            sw.Close();

        }
    }
}
