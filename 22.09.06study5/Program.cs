using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._06study5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int y = x ?? -1;
            Console.WriteLine(y);

            x = 10;
            y = x ?? -1;
            Console.WriteLine(y);
        }
    }
}
