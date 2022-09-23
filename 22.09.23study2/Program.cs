using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._23study2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 10;
            float value2 = 3.14f;
            string str = "Helio";

            StreamWriter sw = new StreamWriter("text.txt");
            sw.WriteLine(value);
            sw.WriteLine(value2);
            sw.WriteLine(str);
            sw.Close();
        }
    }
}
