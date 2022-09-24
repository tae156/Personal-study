using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._24study4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (BinaryWriter bw = new BinaryWriter(new FileStream("test.txt", FileMode.Create))) 
            {
                bw.Write(12);
                bw.Write(3.14f);
                bw.Write("Hello World");
            }
        }
    }
}
